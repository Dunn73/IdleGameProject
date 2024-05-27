
function addHoverCSS(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        element.classList.add('dragging-over');
    }
}

function removeHoverCSS(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        element.classList.remove('dragging-over');
    }
}

function removeRedBorder(element) {
    element.style.border = '';
}

