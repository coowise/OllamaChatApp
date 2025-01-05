# OllamaChatApp

A simple web-based application that utilizes the Ollama `llama3` model to process and respond to queries through an HTTP API.

## Features

- 🌐 Exposes a RESTful API for AI-powered chat functionality.
- 🤖 Executes AI queries using the Ollama `llama3` model.
- 🚀 Fast, lightweight, and easily extendable architecture.
- 📄 Includes Swagger UI for API exploration and testing (in development mode).

## Prerequisites

- .NET SDK (version 6.0 or higher)
- Ollama installed and accessible from the command line
- The AI model `llama3` preloaded in Ollama

## Project Structure

- **Program.cs**: Configures the application and sets up services like controllers and Swagger.
- **ChatController.cs**: Handles incoming API requests and communicates with the Ollama CLI to process messages.

## Installation

1. Clone the repository
2. Build and run the application

## Usage

 ```bash
dotnet run
```

### Sending a Chat Message
- Send a POST request to the endpoint:  
  POST /api/chat
- Include the message as plain text in the request body:  
  "What is artificial intelligence?"
- Example response:  
  "Artificial intelligence is the simulation of human intelligence in machines..."

### API Endpoints
- **Method**: POST  
- **Endpoint**: /api/chat  
- **Description**: Sends a query to the AI model and returns the response.

## Dependencies

- Microsoft.AspNetCore.Mvc (for controller functionality)
- Ollama (external dependency)