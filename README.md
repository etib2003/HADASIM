# Corona_System

## Overview
This project is aimed at managing vaccination data for members. It includes functionalities for tracking vaccination status, updating member information, and generating charts for vaccination statistics.

## Usage
1. Clone the repository to your local machine.
2. Open the solution file in Visual Studio.
3. Make sure to configure the database connection string in `appsettings.json`.
4. Run the database migrations to create the required tables:
   ```
   dotnet ef database update
   ```
5. Start the application.
6. Navigate to the specified URL in your browser to access the application.

### Screenshots
![image](https://github.com/etib2003/HADASIM/assets/116508181/3011d422-c6cd-4987-ae27-d2d1686e2698)
![image](https://github.com/etib2003/HADASIM/assets/116508181/04bb90bb-9773-4fb9-88de-d278f946f91d)
![image](https://github.com/etib2003/HADASIM/assets/116508181/c0bb4333-5fce-424b-abb1-fa85a26f0b80)
![image](https://github.com/etib2003/HADASIM/assets/116508181/0a87f0ba-244b-4f24-b432-4739330c9e66)
![image](https://github.com/etib2003/HADASIM/assets/116508181/e971b31f-912f-4451-bbf6-441532d17d5d)
![image](https://github.com/etib2003/HADASIM/assets/116508181/8d8b91ea-9f05-47f6-af19-64a64e3f29dd)


## External Dependencies
- **Chart.js**: Used for rendering charts in the application. To install, include the following CDN link in your HTML file:
  ```html
  <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
  ```

## Deployment
To deploy this application, follow these steps:
1. Ensure that the target environment meets the system requirements specified in the documentation.
2. Publish the application using the appropriate deployment method for your hosting environment (e.g., Azure, AWS, IIS).
3. Set up the necessary configurations, such as database connection strings and environment variables.
4. Deploy the published application to your hosting environment.
5. Configure any additional services or dependencies required for the application to function correctly in the production environment.
