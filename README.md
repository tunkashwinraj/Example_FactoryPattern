# Example_FactoryPattern
### Project Overview: Factory Pattern for Weather Information and Compute Versions

This project demonstrates the **Factory Pattern**, a widely used design pattern that allows the creation of objects without specifying the exact class of object that will be created. The Factory Pattern centralizes object creation in a factory class, which hides the complexities of object creation from the client. The client interacts only with the factory class to obtain instances of objects, making the client code more maintainable and flexible.

The project consists of two primary examples: one that demonstrates the Factory Pattern for weather data retrieval and another that demonstrates the pattern for managing multiple versions of a compute class. Both examples showcase how the Factory Pattern can simplify object creation and isolate the client from the underlying implementation details.

---

### 1. **Weather Information System Using Factory Pattern**

#### Objective:
To showcase the Factory Pattern in the context of weather information retrieval from different weather services (NOAA and Yahoo). The client will use a factory class to obtain weather data, and the factory will decide which specific weather service to use.

#### Key Components:
1. **ICheckWeather Interface**:
   This interface defines the methods for retrieving weather information:
   - `GetCurrentTemperature(string zipcode)` – Retrieves the current temperature for a given ZIP code.
   - `CheckNextDayForecast(string city, string state)` – Provides a weather forecast for the next day based on city and state.

2. **WeatherNOAA Class**:
   Implements the `ICheckWeather` interface and provides less accurate weather information. This class simulates fetching weather data from NOAA (National Oceanic and Atmospheric Administration), with a simple temperature lookup for given ZIP codes.

3. **WeatherYahoo Class**:
   Implements the `ICheckWeather` interface and provides more detailed weather information. This class simulates fetching weather data from Yahoo, with more specific forecasts and additional weather details (e.g., wind speeds).

4. **WeatherFactory Class**:
   The Factory class decides which weather service (either `WeatherNOAA` or `WeatherYahoo`) to instantiate based on the desired level of forecast accuracy (represented by the `ForecastAccuracy` enum):
   - `GOOD` for `WeatherYahoo` (accurate forecast).
   - `FAIR` for `WeatherNOAA` (approximate forecast).

5. **ForecastAccuracy Enum**:
   Enum that determines the type of weather information required:
   - `GOOD` for detailed, accurate information.
   - `FAIR` for approximate information.

6. **Form with btnWeatherFactory**:
   The form includes a button (`btnWeatherFactory`) that demonstrates the Factory Pattern in action. When clicked, the button will create weather objects for different levels of forecast accuracy and display the results in message boxes.

#### Workflow:
- The client calls the `WeatherFactory.CreateWeatherInfo()` method with the desired `ForecastAccuracy`.
- Based on the accuracy, the factory returns an instance of either `WeatherNOAA` or `WeatherYahoo`.
- The client calls `GetCurrentTemperature()` and `CheckNextDayForecast()` to get the temperature and forecast.
- The client is isolated from the details of which weather service is being used.

#### Example Output:
- The program will display the current temperature from `WeatherNOAA` (less accurate) and `WeatherYahoo` (more accurate) when the button is clicked.

---

### 2. **Compute Version Management Using Factory Pattern**

#### Objective:
This example demonstrates how the Factory Pattern can be used to manage multiple versions of a class. Specifically, it shows how the Factory Pattern allows you to choose between older and newer versions of a `MyCompute` class that calculates cylinder and sphere volumes.

#### Key Components:
1. **ICompute Interface**:
   Defines methods for computing the volume of a cylinder and a sphere:
   - `ComputeCylinderVolume(float radius, float height)` – Computes the volume of a cylinder.
   - `ComputeSphereVolume(float radius)` – Computes the volume of a sphere.

2. **MyCompute Class (Older Version)**:
   An older version of the compute class that uses a hardcoded value for Pi (3.1415).

3. **MyComputev2 Class (Newer Version)**:
   A more accurate version of the compute class that uses `Math.PI` for Pi, ensuring more accurate calculations.

4. **ComputeFactory Class**:
   The factory class decides which version of `ICompute` to create:
   - Version `v1_1` returns an instance of `MyCompute`.
   - Version `v2_0` returns an instance of `MyComputev2`.

5. **CVersion Enum**:
   Enum that specifies the version of the compute class to use:
   - `v1_1` for the older version.
   - `v2_0` for the newer version.

6. **Form with btnComputeFactory**:
   A button (`btnComputeFactory`) on the form that demonstrates the creation of different compute class versions. When clicked, the button creates instances of either `MyCompute` or `MyComputev2` based on the selected version and calculates cylinder volumes.

#### Workflow:
- The client calls the `ComputeFactory.CreateComputeObject()` method with the desired `CVersion`.
- The factory returns an instance of either `MyCompute` (older version) or `MyComputev2` (newer version).
- The client can then use the compute object to calculate cylinder and sphere volumes.

#### Example Output:
- The program will display the cylinder volume calculated using both the old and new versions of the compute class.

---

### Benefits of the Factory Pattern:

1. **Isolation of Object Creation**:
   The client code is decoupled from the specific classes that need to be instantiated. The client does not need to know which weather service or compute version is being used.

2. **Centralized Object Creation**:
   Object creation logic is centralized in the factory class, making the system easier to maintain and extend. If new weather services or compute versions are added in the future, the factory can be updated without changing client code.

3. **Flexibility**:
   The client can request different versions or services dynamically at runtime, improving flexibility and extensibility.

4. **Simplifies Code Maintenance**:
   By using a factory, changes to object creation logic can be handled in one place, reducing code duplication and potential errors.

---

### Conclusion:

The Factory Pattern is a powerful tool in object-oriented design that helps manage object creation in complex systems. In this project, the Factory Pattern is used for weather data retrieval and managing multiple versions of a compute class. By isolating object creation from client code, the pattern simplifies maintenance and enhances flexibility in the software system.
