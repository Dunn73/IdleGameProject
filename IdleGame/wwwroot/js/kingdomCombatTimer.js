self.onmessage = function(e) {
    if (e.data === 'kingdomCombatStart') {
        startTimer();
    } else if (e.data === 'kingdomCombatStop') {
        stopTimer();
    }
}; 

let timerId;

function startTimer() {
    timerId = setInterval(() => {
        postMessage('kingdomCombatTick');
    }, 1000); // Global game timer interval
}

function stopTimer() {
    clearInterval(timerId);
}
