/*
 * Dilmah-Admin-BFF
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class OrdersApiController : ControllerBase
    { 
        /// <summary>
        /// Get Orders
        /// </summary>
        /// <param name="authToken">Authorization bearea token</param>
        /// <response code="200">success</response>
        [HttpGet]
        [Route("/orders")]
        [ValidateModelState]
        [SwaggerOperation("OrdersGet")]
        public virtual IActionResult OrdersGet([FromHeader][Required()]string authToken)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancel an Order
        /// </summary>
        /// <param name="authToken">Authorization bearea token</param>
        /// <param name="">Id of the requested order</param>
        /// <response code="200">success</response>
        /// <response code="400">already canceled</response>
        [HttpPut]
        [Route("/orders/{id}/cancel")]
        [ValidateModelState]
        [SwaggerOperation("OrdersIdCancelPut")]
        public virtual IActionResult OrdersIdCancelPut([FromHeader][Required()]string authToken, [FromRoute][Required] )
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get order by Id
        /// </summary>
        /// <param name="authToken">Authorization bearea token</param>
        /// <param name="">Id of the requested order</param>
        /// <response code="200">success</response>
        [HttpGet]
        [Route("/orders/{id}")]
        [ValidateModelState]
        [SwaggerOperation("OrdersIdGet")]
        public virtual IActionResult OrdersIdGet([FromHeader][Required()]string authToken, [FromRoute][Required] )
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Complete payment
        /// </summary>
        /// <param name="authToken">Authorization bearea token</param>
        /// <param name="">Id of the requested order</param>
        /// <param name="">Id of payment to complete</param>
        /// <response code="200">Success</response>
        /// <response code="400">payment already completed</response>
        [HttpPut]
        [Route("/orders/{orderId}/payments/{id}/complete")]
        [ValidateModelState]
        [SwaggerOperation("OrdersOrderIdPaymentsIdCompletePut")]
        public virtual IActionResult OrdersOrderIdPaymentsIdCompletePut([FromHeader][Required()]string authToken, [FromRoute][Required] , [FromRoute][Required] )
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Ship an Order
        /// </summary>
        /// <param name="authToken">Authorization bearea token</param>
        /// <param name="">Id of the requested order</param>
        /// <param name="">Id of the shipped shipment</param>
        /// <response code="200">success</response>
        /// <response code="204">No Content</response>
        [HttpPut]
        [Route("/orders/{orderId}/shipments/{id}/ship")]
        [ValidateModelState]
        [SwaggerOperation("OrdersOrderIdShipmentsIdShipPut")]
        public virtual IActionResult OrdersOrderIdShipmentsIdShipPut([FromHeader][Required()]string authToken, [FromRoute][Required] , [FromRoute][Required] )
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }
    }
}
