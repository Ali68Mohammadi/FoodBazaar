window.showToaster = function (type,message) {
    if (type === "success") {
        toastr.success(message, undefined, { escapeHtml: true });
    } else if (type === "error") {
        toastr.error(message, undefined, { escapeHtml: true });
    } else if (type === "warning") {
        toastr.warning(message, undefined, { escapeHtml: true });
    } else if (type === "info") {
        toastr.info(message, undefined, { escapeHtml: true });
    }
}

function showPageToasts() {
    for (const notification of document.querySelectorAll("[data-toast-type][data-toast-message]")) {
        window.showToaster(notification.dataset.toastType, notification.dataset.toastMessage);
        notification.remove();
    }
}

if (document.readyState === "loading") {
    document.addEventListener("DOMContentLoaded", showPageToasts, { once: true });
} else {
    showPageToasts();
}

window.Blazor?.addEventListener("enhancedload", showPageToasts);
