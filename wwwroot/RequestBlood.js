document.getElementById('bloodRequestForm').addEventListener('submit', function (event) {
    event.preventDefault();

    var hospital = document.getElementById('hospital').value;
    var city = document.getElementById('city').value;
    var town = document.getElementById('town').value;
    var bloodType = document.getElementById('blood-type').value;
    var units = document.getElementById('units').value;

    var requestData = {
        hospital: hospital,
        city: city,
        town: town,
        bloodType: bloodType,
        units: units
    };

    fetch('https://backend-api-url/request-blood', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(requestData),
    })
    .then(response => response.json())
    .then(result => {
        console.log(result);
        alert('Blood request successful!');
        document.getElementById('bloodRequestForm').reset();
    })
    .catch(error => {
        console.error('Error:', error);
        alert('Failed to request blood. Please try again.');
    });
});
