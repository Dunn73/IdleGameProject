// wwwroot/js/timerWorker.js
self.onmessage = function(e) {
    if (e.data === 'start') {
        startTimer();
    } else if (e.data === 'stop') {
        stopTimer();
    }
};

let timerId;

function startTimer() {
    timerId = setInterval(() => {
        postMessage('tick');
    }, 1000); // Send a 'tick' message every second
}

function stopTimer() {
    clearInterval(timerId);
}