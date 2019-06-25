function drawClock(canvas, x, y, r) {
    var ctx = canvas.getContext('2d');
    var pointRadius = 6;
    var displacement = pointRadius / 2;  /* point doesn't overlap circle */
    ctx.beginPath();
    ctx.arc(x, y, r, 0, Math.PI * 2);
    ctx.stroke();
    ctx.fillStyle = 'rgb(0, 0, 139)';
    for (i = 1; i <= 12; i++) {
        x1 = x - displacement + Math.sin(i * Math.PI * 2 / 12) * (r - displacement);
        y1 = y - displacement - Math.cos(i * Math.PI * 2 / 12) * (r - displacement);
        ctx.fillRect(x1, y1, pointRadius, pointRadius);
    }
}

function createColor(value) {
    return ('rgb(255, ' + (255 - value * 255 / 30) + ', 0)');
}

function getAndDrawHourlyWeather(canvas, x, y, r, serialized) {
    var hourlyWeather = JSON.parse(serialized);
    var _lineWidth = 7;
    var section = 30;  /* angle */
    for (var key in hourlyWeather) {
        if (0 <= key && key <= 12) {
            var color = createColor(hourlyWeather[key]);
            var start = - Math.PI / 2 + parseInt(key, 10) * Math.PI / 6;
            drawArc(canvas, x, y, r, color, _lineWidth, start, section);
        }
    }
}

function drawArc(canvas, x, y, r, color, width, start, section) {
    var ctx = canvas.getContext('2d');
    ctx.strokeStyle = color;
    ctx.lineWidth = width;
    var end = start + section * Math.PI / 180;
    ctx.beginPath();
    ctx.arc(x, y, r, start, end);
    ctx.stroke();
    ctx.closePath();
}

function addDegreeInHover(serialized) {
    var hourlyWeather = JSON.parse(serialized);
    for (var key in hourlyWeather) {
        if (0 <= parseInt(key, 10) <= 12) {
            document.getElementById(key).innerHTML = hourlyWeather[key];
        }
    }
}