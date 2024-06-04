let gameLoopInterval;
let lastTimestamp = 0;

function gameLoop(timestamp) {
    if (!lastTimestamp) lastTimestamp = timestamp;
    const deltaTime = Math.min(timestamp - lastTimestamp, 1000); // Cap deltaTime to 100ms
    lastTimestamp = timestamp;

    updateProgressBar(deltaTime);

    gameLoopInterval = requestAnimationFrame(gameLoop);
}

function updateProgressBar(deltaTime) {
    const progressBarFill = document.getElementById("progressBarFill");
    if (progressBarFill) {
        let currentWidth = parseFloat(progressBarFill.style.width) || 0;
        currentWidth += (deltaTime / 1000) * 100; // Increase by percentage per second

        if (currentWidth >= 100) {
            currentWidth = 0; // Reset progress bar to 0 when it hits 100%
            // Disable transition
            progressBarFill.style.transition = 'none';
            progressBarFill.style.width = currentWidth + '%';
        } else {
            progressBarFill.style.width = currentWidth + '%';
        }
    }
}

window.startGameLoop = function () {
    if (!gameLoopInterval) {
        gameLoopInterval = requestAnimationFrame(gameLoop);
    }
}

window.stopGameLoop = function () {
    if (gameLoopInterval) {
        cancelAnimationFrame(gameLoopInterval);
        gameLoopInterval = null;
        lastTimestamp = 0;

        const progressBarFill = document.getElementById("progressBarFill");
        if (progressBarFill) {
            progressBarFill.style.width = '0%'; // Set the width to 0%
        }
    }
}
