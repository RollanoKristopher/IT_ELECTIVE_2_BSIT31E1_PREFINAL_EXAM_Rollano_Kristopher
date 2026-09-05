document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.reveal-btn').forEach(function (btn) {
        btn.addEventListener('click', function () {
            var target = document.getElementById(btn.dataset.target);
            if (!target) return;
            var isShown = target.classList.toggle('show');
            btn.textContent = isShown ? '> HIDE_ANSWER' : '> RUN answer.exe';
        });
    });
});
