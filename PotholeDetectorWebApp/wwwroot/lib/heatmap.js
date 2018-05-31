
$(document).ready( function () {

   // Data fetch and Heatmap configuration

try {
    var httpRequest = new XMLHttpRequest();
        httpRequest.open('GET','/Home/GetData',true)
        httpRequest.onload = function(e){
        if (httpRequest.readyState === 4) {
         if (httpRequest.status === 200) {
          
            var responseData = JSON.parse(httpRequest.responseText);
            var baseLayer =  L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}', {
                attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, Imagery © <a href="https://www.mapbox.com/">Mapbox</a>',
                maxZoom: 20,
                id: 'mapbox.streets',
                accessToken: ''
            });


            var testData = {
              max: 8,
              data: responseData
            };

            var cfg = {
              "radius": 0.001,
              "maxOpacity": .8, 
              "scaleRadius": true, 
              "useLocalExtrema": false,
              latField: 'lat',
              lngField: 'lon',
              valueField: 'numberOfPotholes'
            };


            var heatmapLayer = new HeatmapOverlay(cfg);

            var map = new L.Map('mapid', {
              center: new L.LatLng(41.89353, 12.5036529),
              zoom: 13,
              layers: [baseLayer, heatmapLayer]
            });

            heatmapLayer.setData(testData);

        } else {
          console.error(httpRequest.statusText);
        }
      }
    };
    httpRequest.onerror = function (e) {
      console.error(httpRequest.statusText);
    };
    httpRequest.send(null);
} catch(err){

}




} );


   