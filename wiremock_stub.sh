curl -X POST \
--data '{ "request": { "url": "/get?orderid=38", "method": "GET" }, "response": { "status": 200, "body": "{\r\n  \"orderId\": 38,\r\n  \"status\" : \"Transaction success\",\r\n  \"amount\" : 235.2,\r\n  \"currencyCode\" : \"USD\",\r\n  \"side\" : \"BUY\"\r\n}" }}' \
http://localhost:8080/__admin/mappings/new

curl -X POST \
--data '{ "request": { "url": "/get?orderid=300", "method": "GET" }, "response": { "status": 400, "body": "{\r\n  \"orderId\": 300,\r\n  \"status\" : \"OrderId not found\"\r\n}" }}' \
http://localhost:8080/__admin/mappings/new


curl -X POST \
--data '{
  "request": {
    "url": "/api/v3/order",
    "method": "POST",
    "bodyPatterns": [
      {
        "equalToJson": {
            "clientOrderId": "32gTWt5F6TOUQ0DCLeiauMP","price": "0.2202","side:": "BUY","quantity": 0.335024
        }
      }
    ]
  },
  "response": {
    "status": 200,
    "body": "{\"symbol\" :1539240640355,\n\"orderId\":1,\n\"clientOrderId\":\"jzzcf77PTveGhAjzBZhaXn\",\n\"transactTime\":1539240642638, \n\"price\":0,\"side\":\"BUY\",\"status\":\"SUCCESS\"}"
  }
}' \
http://localhost:8080/__admin/mappings/new


curl -X POST \
--data '{
  "request": {
    "url": "/api/v3/order",
    "method": "POST",
    "bodyPatterns": [
      {
        "equalToJson": {
          "clientOrderId":"jzzcf77PTveGhAjzBZhaXn","price":"0.234","side:":"SELL","quantity":0
        }
      }
    ]
  },
  "response": {
    "status": 400,
    "body": "{\"symbol\" :1539240640355,\n\"orderId\":1,\n\"clientOrderId\":\"jzzcf77PTveGhAjzBZhaXn\",\n\"transactTime\":1539240642638, \n\"price\":0,\"side\":\"BUY\",\"status\":\"FAILED\"}"
  }
}' \
http://localhost:8080/__admin/mappings/new
