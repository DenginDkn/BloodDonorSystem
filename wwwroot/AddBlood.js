function authenticate(branchId) {
    return true;
}

function addBlood(event) {
    event.preventDefault();

    // Get form values
    var bloodBank = document.getElementById('blood-bank').value;
    var donorName = document.getElementById('donor-name').value;
    var bloodType = document.getElementById('blood-type').value;
    var donationDate = document.getElementById('donation-date').value;
    var units = document.getElementById('units').value;

    var branchId = 'konak';

    if (!authenticate(branchId)) {
        alert('Authentication failed. Access denied.');
        return;
    }

    alert(`Blood Bank: ${bloodBank}\nDonor Name: ${donorName}\nBlood Type: ${bloodType}\nDonation Date: ${donationDate}\nUnits: ${units}`);
}
