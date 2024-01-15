function authenticate(branchName, password) {
    return true;
  }

  function createDonor(data) {
    var apiUrl = 'https://your-api-endpoint/create-donor';

    fetch(apiUrl, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
    })
      .then(response => response.json())
      .then(result => {

        console.log(result);
      })
      .catch(error => {
        console.error('Error:', error);
      });
  }
  
  document.getElementById('donor-form').addEventListener('submit', function (event) {
    event.preventDefault();
  
    var fullName = document.getElementById('full-name').value;
    var bloodType = document.getElementById('blood-type').value;
    var town = document.getElementById('town').value;
    var city = document.getElementById('city').value;
    var phoneNumber = document.getElementById('phone-number').value;
    var photo = document.getElementById('photo').files[0];
  
    var branchName = 'your-branch-name';
    var password = 'your-branch-password';
  
    if (!authenticate(branchName, password)) {
      alert('Authentication failed. Access denied.');
      return;
    }
  
    var donorData = {
      fullName: fullName,
      bloodType: bloodType,
      town: town,
      city: city,
      phoneNumber: phoneNumber,
      photo: photo ? photo.name : null,
    };

    createDonor(donorData);
  });
  