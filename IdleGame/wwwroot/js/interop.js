window.timerWorker = {
    resourceWorker: null,
    combatWorker: null,

    resourceStart: function () {
        console.log('resourceStart called'); // Log to verify function call
        if (!this.resourceWorker) {
            this.resourceWorker = new Worker('/js/resourceWorkerTimer.js');
            this.resourceWorker.onmessage = function (e) {
                if (e.data === 'resourceTick') {
                    DotNet.invokeMethodAsync('IdleGame', 'OnResourceTick');
                }
            };
        }
        this.resourceWorker.postMessage('resourceStart');
    },

    resourceStop: function () {
        console.log('resourceStop called'); // Log to verify function call
        if (this.resourceWorker) {
            this.resourceWorker.postMessage('resourceStop');
            this.resourceWorker.terminate();
            this.resourceWorker = null;
        }
    },

    kingdomCombatStart: function () {
        console.log('kingdomCombatStart called'); // Log to verify function call
        if (!this.combatWorker) {
            this.combatWorker = new Worker('/js/kingdomCombatTimer.js');
            this.combatWorker.onmessage = function (e) {
                if (e.data === 'kingdomCombatTick') {
                    DotNet.invokeMethodAsync('IdleGame', 'OnKingdomCombatTick');
                }
            };
        }
        this.combatWorker.postMessage('kingdomCombatStart');
    },

    kingdomCombatStop: function () {
        console.log('kingdomCombatStop called'); // Log to verify function call
        if (this.combatWorker) {
            this.combatWorker.postMessage('kingdomCombatStop');
            this.combatWorker.terminate();
            this.combatWorker = null;
        }
    },
};
