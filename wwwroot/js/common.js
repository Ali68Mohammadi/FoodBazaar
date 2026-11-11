function ShowConfirmationModal() {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('bsConfirmationModal')).show();
} 

function HideConfirmationModal() {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('bsConfirmationModal')).hide();
}

document.addEventListener("show.bs.modal", function (event) {
    const modal = event.target;
    if (modal.id !== "deleteUserModal") {
        return;
    }

    const trigger = event.relatedTarget;
    const userId = trigger?.dataset.deleteUserId;
    if (!userId) {
        event.preventDefault();
        return;
    }

    modal.querySelector('[name="UserId"]').value = userId;
    modal.querySelector(".modal-title").textContent =
        "Delete " + trigger.dataset.deleteUserName + " permanently?";
});
