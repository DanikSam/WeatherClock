function drawClock(canvas, x, y, r) {
    var ctx = canvas.getContext('2d');
    var pointRadius = 6;
    var offset = pointRadius / 2;  /* point doesn't overlap circle */
    ctx.beginPath();
    ctx.arc(x, y, r, 0, Math.PI * 2);
    ctx.stroke();
    ctx.fillStyle = 'rgb(0, 0, 139)';
    for (i = 1; i <= 12; i++) {
        x1 = x - offset + Math.sin(i * Math.PI * 2 / 12) * (r - offset);
        y1 = y - offset - Math.cos(i * Math.PI * 2 / 12) * (r - offset);
        ctx.fillRect(x1, y1, pointRadius, pointRadius);
    }
}

function GetColor(tempDegree) {
    return ('rgb(255, ' + (255 - tempDegree * 255 / 30) + ', 0)');
}

function drawArc(canvas, x, y, r, color, _lineWidth, start, end) {
    var ctx = canvas.getContext('2d');
    ctx.strokeStyle = color;
    ctx.lineWidth = _lineWidth;
    ctx.beginPath();
    ctx.arc(x, y, r, start, end);
    ctx.stroke();
    ctx.closePath();
}

function convertTime(time) {
    hour = time.getHours();
    minutes = time.getMinutes();
    return (- Math.PI / 2 + hour * Math.PI * 2 / 12 + minutes * Math.PI * 2 / 12 / 60);
}

function DrawHourlyWeather(canvas, x, y, r, serialized) {
    var hourlyWeather = JSON.parse(serialized);
    var _lineWidth = 7;
    for (var key in hourlyWeather) {
        if (0 <= parseInt(key.substring(0, 2)) && parseInt(key.substring(0, 2)) <= 12) {
            var color = GetColor(hourlyWeather[key]);
            var time = new Date();
            time.setHours(parseInt(key.substring(0, 2)));
            time.setMinutes(parseInt(key.substring(3, 5)));
            var start = convertTime(time);
            var end = start + (60 - time.getMinutes()) * Math.PI / (180 * 2);
            drawArc(canvas, x, y, r, color, _lineWidth, start, end);
        }
    }
}

function addDegreeInHover(serialized) {
    var hourlyWeather = JSON.parse(serialized);
    for (var key in hourlyWeather) {
        if (0 <= key.substring(0, 2) && key.substring(0, 2) <= 12) {
            document.getElementById(parseInt(key.substring(0, 2))).innerHTML = hourlyWeather[key];
        }
    }
}