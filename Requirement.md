In this challenge, you will have to create a WebService and test it. You will then have to publish your code sources to [Github](https://github.com), and send the link to it@lemonway.com with your CV in attachment.

* Feel free to use any library / framework or **copy/paste codes of others** with respect of the author's license. Please list the used libraries / code snippets in your README.md file.
* There is no time limit.

# 1) Create a ASP.NET **SOAP** WebService

Open Visual Studio (the latest Community Edition is recommended).

Create a ASP.NET **SOAP** WebService (not a WCF WebService or a Restful WebService) with the following **Web Methods**:

* `int Fibonacci(int n)`
* `string XmlToJson(string xml)`

## 1.1) `Fibonacci` service

The Fibonacci service takes input an integer **N**, and returns the **N**th value in the [Fibonacci sequence](https://en.wikipedia.org/wiki/Fibonacci_number)

Argument conditions:

* 1 <= N <= 100
* otherwise the service must return -1

for example:

```
Fibonacci(1) must return 1
Fibonacci(2) must return 1
Fibonacci(3) must return 2
Fibonacci(4) must return 3
Fibonacci(5) must return 5
Fibonacci(6) must return 8
etc..
Fibonacci(-101) must return -1
Fibonacci(1000) must return -1
```

note : we are aware that in production, some best practices (such as the use of exceptions) would be applied.


## 1.2) `XmlToJson` service

The **XmlToJson** service takes as input a xml string and returns the json form of the xml string. It will return **"Bad Xml format"** if the input string is not a well-formed xml.

for example:

* `XmlToJson("<foo>bar</foo>")` must return 
```
{ "foo": "bar" }
```

* `XmlToJson("<foo>hello</bar>")` must return
```
Bad Xml format
```

* `XmlToJson("<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>")` must return
```
{
  "TRANS": {
    "HPAY": {
      "ID": "103",
      "STATUS": "3",
      "EXTRA": {
        "IS3DS": "0",
        "AUTH": "031183"
      },
      "MLABEL": "501767XXXXXX6700",
      "MTOKEN": "project01"
    }
  }
}
```

Feel free to use any library on the official nuget repository. We advise you not to make your own XML or Json parser.

note: XML attributes (e.g. <tag attr_name="attr_value>...") should be ignored.

# 2) Create a WebService Consumer

You will choose to implement one of these two applications (or both if you want to).
Lemon Way's prefered choice is the second option. However if you are a .NET beginner or if you don't want to spend more time with this challenge then the first option is good enough for us.

## 2.1) Option 1 - A Console Application

- Run the WebService on your `localhost`
- Create a New console application which will call your WebService (on your `localhost`) to compute the `Fibonacci(10)` and print the result to the console.

## 2.2) Option 2 - A WinForm Application (higher appreciation than option 1)

- Run the WebService on your `localhost`
- Create a New WinForm application: 
The main form contains only 1 button with the label `"Compute Fibonancci(10)"`. When user click on this button, your WinForm app will have to
  + Display a `BusyForm` as a **modal dialog** (which is not closable or cancellable, and which should lock the Main Form)
  + Asynchronously call the Web service `Fibonacci(10)` on your `localhost`
  + When the Web service returns the result, the `BusyForm` will have to automaticly disappeared, and the result will be displayed in a `MessageBox.Show()`

**Hints**

We want to test How will you implement a `BusyForm` (or `WaitingForm`) while executing a long operation. It is a typical problem of every WinForm application.
- You can try to simulate as if the computation is slow on server side. You can add a `sleep(2000)` so that the compute of `Fibonacci(10)` takes 2 seconds on the server side for example.
- Make sure that the interface does NOT freeze during remote service invocation and computation.
- Think about using the [Asynchronous programming](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/) to make a more efficient I/O codes.
- The interface we are asking is minimalist with only one button. Feel free to make it a rich / useful interface to interact with these 2 webservice if you want to.
- Don't try to use WPF, we are not interested.

# 3) Publish the code to Github

Push your code to Github, so that after `git clone`, we can open your solution file (`*.sln`) in Visual Studio and run your WebService on our `localhost`.

We are using Visual Studio Community edition on Windows 10. If necessary, please attach a `README.txt` with instructions to help us run / test your WebService on our `localhost`.

# 4) Bonus point (optional)

* **Unit test project**  
  Any solid .NET developer should know how to write unit tests. We recommended the Microsoft unit test framework. If you are using other framework, give us instruction on how to run your test. 

* **log4net**  
  We encourage you to log every coming request / response / error of your WebService to a log file using the `log4net` library which is also available on NuGet.

* **Json-based WebService** (not a RESTful Service)  
  Configure your WebService so that it could handle json-based request / response. 
  Be careful: Json-based Web Service is not the same as RESTful Service. You are not supposed to make RESTful Service.

  **Hint**: The only change is in web.config. You don't have to change anything in your codes (`*.cs`)
