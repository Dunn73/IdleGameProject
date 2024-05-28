self.onmessage = function(e) {
    if (e.data === 'resourceStart') {
        startTimer();
    } else if (e.data === 'resourceStop') {
        stopTimer();
    }
};

let timerId;

function startTimer() {
    timerId = setInterval(() => {
        postMessage('resourceTick');
    }, 200); // Global game timer interval
}

function stopTimer() {
    clearInterval(timerId);
}
