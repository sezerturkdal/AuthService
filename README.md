<h1 style="text-align: center; font-family: Arial, sans-serif; color: #2c3e50;">
    🚀 Authentication API with .NET Core & MongoDB
</h1>

<p style="font-size: 18px; color: #34495e; text-align: center;">
    A secure authentication API built with .NET Core and MongoDB, implementing JWT authentication and password hashing.
</p>

<h2 style="color: #2980b9;">✨ Features</h2>
<ul style="font-size: 16px; color: #2c3e50;">
    <li>📌 <strong>User registration with password hashing (BCrypt)</strong></li>
    <li>📩 <strong>JWT-based authentication & authorization</strong></li>
    <li>📊 <strong>MongoDB integration for storing user data</strong></li>
    <li>🔒 <strong>Secure password verification</strong></li>
    <li>🔑 <strong>API protection using [Authorize] attribute</strong></li>
</ul>

<h2 style="color: #27ae60;">⚙️ Technologies</h2>
<ul style="font-size: 16px; color: #2c3e50;">
    <li>🌐 <strong>C# / .NET Core</strong></li>
    <li>🛠️ <strong>ASP.NET Core Web API</strong></li>
    <li>🗄️ <strong>MongoDB (Atlas)</strong></li>
    <li>🔑 <strong>JWT (JSON Web Token) for Authentication</strong></li>
    <li>🔐 <strong>BCrypt for Password Hashing</strong></li>
</ul>

<h2 style="color: #2ecc71;">🔧 Architecture & Tools</h2>
<ul style="font-size: 16px; color: #2c3e50;">
    <li>🛠 <strong>Dependency Injection</strong> - Loose coupling for better maintainability</li>
    <li>📝 <strong>JWT Authentication</strong> - Ensures secure access control</li>
    <li>📦 <strong>MongoDB Integration</strong> - Data persistence for user information</li>
</ul>

<h2 style="color: #8e44ad;">📦 Installation</h2>
<pre style="background: #ecf0f1; padding: 10px; border-radius: 5px;">
<code>
git clone https://github.com/sezerturkdal/AuthService.git
cd AuthService
dotnet restore
dotnet run --project AuthService.API
</code>
</pre>

<h2 style="color: #d35400;">📡 API Endpoints</h2>
<table style="border-collapse: collapse; width: 100%; border: 1px solid #ddd;">
    <tr style="background: #f4f4f4;">
        <th style="padding: 10px; border: 1px solid #ddd;">Method</th>
        <th style="padding: 10px; border: 1px solid #ddd;">Endpoint</th>
        <th style="padding: 10px; border: 1px solid #ddd;">Description</th>
    </tr>
    <tr>
        <td style="padding: 10px; border: 1px solid #ddd;">POST</td>
        <td style="padding: 10px; border: 1px solid #ddd;">/api/auth/register</td>
        <td style="padding: 10px; border: 1px solid #ddd;">Register a new user</td>
    </tr>
    <tr>
        <td style="padding: 10px; border: 1px solid #ddd;">POST</td>
        <td style="padding: 10px; border: 1px solid #ddd;">/api/auth/login</td>
        <td style="padding: 10px; border: 1px solid #ddd;">Login and get JWT token</td>
    </tr>
</table>

<h2 style="color: #f39c12;">🛠 Environment Variables</h2>
<p>Instead of storing sensitive information in <code>appsettings.json</code>, use .NET User Secrets to securely store your credentials locally:</p>
<pre style="background: #ecf0f1; padding: 10px; border-radius: 5px;">
<code>
dotnet user-secrets init
dotnet user-secrets set "MongoDB:ConnectionString" "YourMongoDBConnectionString"
dotnet user-secrets set "Jwt:Key" "YourSuperSecretKey"
</code>
</pre>

<h2 style="color: #16a085;">🚀 Run Locally</h2>
<p>Run the application locally:</p>
<pre style="background: #ecf0f1; padding: 10px; border-radius: 5px;">
<code>dotnet run --project AuthService.API</code>
</pre>

<h2 style="color: #e74c3c;">📜 License</h2>
<p>MIT License</p>

<h2 style="color: #3498db;">🤝 Contribute</h2>
<p>Contributions are welcome! Fork & submit a pull request. 🚀</p>
