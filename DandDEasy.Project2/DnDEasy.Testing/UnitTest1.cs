using DandDEasy_WEB.Controllers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.Protected;
using System.Net;
using System.Text;
using System.Net.Http.Headers;

namespace DnDEasy.Testing
{
    public class UnitTest1
    {

        //[Fact]
        //public async void ShouldGetUser()
        //{
        //    //Arrange
        //    string numberJson = JsonConvert.SerializeObject(new List<int>() { 1, 2, 3, 4, 5 });

        //    var httpMessageHandler = new Mock<HttpMessageHandler>();
        //    httpMessageHandler.Protected()
        //        .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
        //            ItExpr.IsAny<CancellationToken>())
        //        .Returns(Task.FromResult(new HttpResponseMessage
        //        {
        //            StatusCode = HttpStatusCode.OK,
        //            Content = new StringContent(numberJson, Encoding.UTF8, "application/json"),
        //        }));

        //    HttpClient httpClient = new HttpClient(httpMessageHandler.Object);
        //    httpClient.BaseAddress = new Uri(@"http://localhost:63781/v1/");
        //    httpClient.DefaultRequestHeaders.Accept.Clear();
        //    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    UserController TheUsers = new UserController(httpClient);

        //    //Act
        //    IActionResult result = await TheUsers.Index();

        //    //Assert
        //    OkObjectResult resultObject = result as OkObjectResult;
        //    Assert.NotNull(resultObject);

        //    List<int> numbers = resultObject.Value as List<int>;
        //    Assert.Equal(5, numbers.Count);
        //}
    }
}
