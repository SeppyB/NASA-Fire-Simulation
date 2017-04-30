function ForestWildfire(init_grid) {
    this.forest_grid = init_grid;
    this.x_max = init_grid.length;
    this.y_max = init_grid[0].length;
}

ForestWildfire.prototype.update_fire_spread = function(new_fire_centers, wind_speed, wind_dir, humidity) {
    var changes = [];
    var new_forest_grid = this.forest_grid.map(function(arr) {
        return arr.slice();
    });

    for (var i = 0; i < this.x_max; i++) {
        for (var j = 0; j < this.y_max; j++) {
            var old_state = this.forest_grid[i][j];
            var new_state = this.update_fire_state(i, j, wind_speed, wind_dir, humidity);

            if (old_state != new_state) {
                changes.push({x: i, y: j});
                new_forest_grid[i][j] = new_state;
            }
        }
    }

    for (var i = 0; i < new_fire_centers.length; i++) {
        var fire_center = new_fire_centers[i];
        changes.push({x: fire_center.x, y: fire_center.y});
        new_forest_grid[fire_center.x][fire_center.y] = FIRE;
    }

    this.forest_grid = new_forest_grid;

    return changes;
}

ForestWildfire.prototype.update_fire_state = function(i, j, wind_speed, wind_dir, humidity) {
    if (this.forest_grid[i][j] == TREE) {
        if (i > 0 && this.forest_grid[i-1][j] == FIRE
            || j > 0 && this.forest_grid[i][j-1] == FIRE
            || i < this.x_max-1 && this.forest_grid[i+1][j] == FIRE
            || j < this.y_max-1 && this.forest_grid[i][j+1] == FIRE) {
            
            var rnd = Math.random();
            if (rnd <= 0.70) {
                return FIRE;
            }
        }
    }

    return this.forest_grid[i][j];
}

/*
 * Calculates fire spread rate
 *
 * Parameters
 * fmc - fuel moisture content, percent
 * v - wind speed, mi/h
 * alpha - angle formed with the direction of the wind, grad
 * 
 * Returns
 * Fire spread rate, m/s
*/
function fsr(fmc, v, alpha) {
    var v2 = v * v;
    var fmc2 = fmc * fmc;

    var angle_coeff;
    if (alpha == 0) {
        angle_coeff = 1;
    } else {
        angle_coeff = 0.0075 * Math.pow(alpha, -0.196) * v2 + (0.0002 * alpha - 0.0985) * v + 4.0767 * Math.pow(alpha, -0.429);
    }
    var fsr = (0.0002 * fmc2 - 0.008 * fmc + 0.1225) * v2 +
              (-0.0008 * fmc2 + 0.0005 * fmc + 0.1823) * v +
              (0.0019 * fmc2 - 0.0924 + 1.2675);

    return fsr * 0.3048 / 60.0;
}