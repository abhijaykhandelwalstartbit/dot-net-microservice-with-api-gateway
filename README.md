# .NET 6 Microservices Sample with Ocelot API Gateway

## Projects

- **ProductService** (port 5001)
- **OrderService** (port 5002)
- **ApiGateway** (port 5000, uses Ocelot)

## How to Run

1. Open three terminals.

2. In `/ProductService`:
    ```
    dotnet restore
    dotnet run
    ```

3. In `/OrderService`:
    ```
    dotnet restore
    dotnet run
    ```

4. In `/ApiGateway`:
    ```
    dotnet restore
    dotnet run
    ```

5. Test endpoints:
    - [http://localhost:5000/products](http://localhost:5000/products)
    - [http://localhost:5000/orders](http://localhost:5000/orders)

---

## Notes
- Each service is independent and runs on its own port.
- The API Gateway (Ocelot) acts as the entry point for clients.
- You can extend this with Docker Compose or more advanced features as needed.
