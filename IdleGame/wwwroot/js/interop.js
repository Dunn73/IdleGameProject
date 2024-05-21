// wwwroot/js/interop.js
window.timerWorker = {
    worker: null,

    start: function () {
        if (!this.worker) {
            this.worker = new Worker('/js/timerWorker.js');
            this.worker.onmessage = function (e) {
                if (e.data === 'tick') {
                    DotNet.invokeMethodAsync('IdleGame', 'OnTimerTick');
                }
            };
        }
        this.worker.postMessage('start');
    },

    stop: function () {
        if (this.worker) {
            this.worker.postMessage('stop');
            this.worker.terminate();
            this.worker = null;
        }
    },

    invokeOnTimerTick: function (globalSave) {
        DotNet.invokeMethodAsync('IdleGame', 'OnTimerTick', globalSave)
            .catch(error => console.error('Error invoking OnTimerTick:', error));
    }
};