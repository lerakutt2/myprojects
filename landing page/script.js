document.addEventListener('DOMContentLoaded', function () {
    'use strict';

    var buyButtons = document.querySelectorAll('.buybutton'),
        buyModal = document.getElementById('buymodal'),
        closeModalButton = document.getElementById('closeModal'),
        buyModalButton = document.getElementById('buyModal');

    if (!buyButtons || !buyModal || !closeModalButton || !buyModalButton) {
        return;
    }

    function openBuyModal() {
        buyModal.classList.add('open');
    }

    function closeBuyModal() {
        buyModal.classList.remove('open');
    }

    buyButtons.forEach(function (button) {
        button.addEventListener('click', openBuyModal);
    });

    closeModalButton.addEventListener('click', closeBuyModal);
    buyModalButton.addEventListener('click', closeBuyModal);
});