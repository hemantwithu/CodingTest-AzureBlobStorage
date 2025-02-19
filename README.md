### **🚀 Setup Steps**  

#### **1 Prerequisites**  
- Install **Node.js** (Check with `node -v`).  
- Install **npm** (Check with `npm -v`).  

#### **2 Clone the Repository**  
```sh
git clone https://github.com/hemantwithu/CodingTest-AzureBlobStorage.git
cd AzureBlobApi
cd azure-blob-display
```

#### **3 Install Dependencies**  
```sh
npm install
```

#### **4 Start the .NET project**  
```sh
dotnet build
dotnet run
```
- The app will be available at 👉 **http://localhost:5007/**
- Navigate to the API endpoint - 👉 **http://localhost:5007/api/properties**

#### **5  Start the Development Server**  
```sh
npm run dev
```
- The app will be available at 👉 **http://localhost:3000**  

#### **6 Configure API Endpoint (If Needed)**  
- The app fetches data from the backend API at:  
  ```
  http://localhost:5007/api/properties
  ```
- If the API URL changes, update `API_URL` in **`src/components/PropertyList.jsx`**:  
  ```js
  const API_URL = "http://new-api-url.com/api/properties";
  ```

#### **6️⃣ Run the Backend API**  
- Ensure the backend API (C#) is running.  
- The API should fetch data from **Azure Blob Storage** securely.  

#### **7️⃣ Test the Application**  
- Open the browser and navigate to **http://localhost:3000**.  
- Click on a property to expand its details.  
- Click on spaces to view rent details.  
 
