// script.js
document.addEventListener('DOMContentLoaded', function() {
    const loginForm = document.getElementById('loginFormElement');
    const errorMessage = document.getElementById('errorMessage');
    
    // Check if user is already "logged in" (for demo)
    if(localStorage.getItem('loggedIn') === 'true') {
        showDatabaseContent();
    }
    
    loginForm.addEventListener('submit', function(e) {
        e.preventDefault();
        
        const username = document.getElementById('username').value;
        const password = document.getElementById('password').value;
        
        // DEMO ONLY - In real app, use server-side authentication
        if (username === 'admin' && password === 'RBLS123') {
            localStorage.setItem('loggedIn', 'true');
            showDatabaseContent();
        } else {
            errorMessage.textContent = 'Access denied. Invalid credentials.';
        }
    });
});

function showDatabaseContent() {
    document.getElementById('loginForm').style.display = 'none';
    document.getElementById('databaseContent').style.display = 'block';
    loadData();
}

function logout() {
    localStorage.removeItem('loggedIn');
    document.getElementById('loginForm').style.display = 'block';
    document.getElementById('databaseContent').style.display = 'none';
    document.getElementById('username').value = '';
    document.getElementById('password').value = '';
    document.getElementById('errorMessage').textContent = '';
}

function loadData() {
    // This would be replaced with actual database fetch
    const dataDisplay = document.getElementById('dataDisplay');
    dataDisplay.innerHTML = `
        <h3>Sample Data</h3>
        <p>This would be connected to your database in a real implementation.</p>
        <div class="data-sample">
            <p>For a real database connection, you would need:</p>
            <ul>
                <li>Backend API (Node.js, PHP, Python, etc.)</li>
                <li>Database (MySQL, MongoDB, etc.)</li>
                <li>Proper authentication system</li>
            </ul>
        </div>
    `;
}
