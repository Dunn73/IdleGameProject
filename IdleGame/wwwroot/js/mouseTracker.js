window.captureMousePosition = function (dotnetHelper) {
    document.addEventListener('mousemove', function (event) {
        dotnetHelper.invokeMethodAsync('UpdateMousePosition', event.clientX, event.clientY);
    });
};
