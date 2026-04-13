
function BookHotel(obj) {

    // Get check-in date (MM/DD/YYYY)
    var arrDate = getObj("txtchin").value.substring(3, 5);
    var arrDateMonth = getObj("txtchin").value.substring(0, 2);
    var arrDateYear = getObj("txtchin").value.substring(6, 10);

    // Get check-out date (MM/DD/YYYY)
    var depDate = getObj("txtchout").value.substring(3, 5);
    var depDateMonth = getObj("txtchout").value.substring(0, 2);
    var depDateYear = getObj("txtchout").value.substring(6, 10);

    // Rooms (default = 1)
    var rooms = getObj("nroom").value || 1;

    // Format dates → YYYY-MM-DD
    var checkInDate = arrDateYear + "-" + arrDateMonth + "-" + arrDate;
    var checkOutDate = depDateYear + "-" + depDateMonth + "-" + depDate;

    // ✅ ResNexus Booking URL
    var bookingLinkURL =
        "https://resnexus.com/resnexus/reservations/book/C41AB3D8-05C3-45AD-9BD3-8CEAA0F53EBC"
        + "?arrivalDate=" + checkInDate
        + "&departureDate=" + checkOutDate
        + "&rooms=" + rooms;

    // Open booking link in new tab
    $(obj).attr("href", bookingLinkURL);
    $(obj).attr("target", "_blank");

    // DataLayer tracking
    dataLayer.push({ 'event': 'BookNow' });

    // Device-based email logic
    var ua = navigator.userAgent;
    if ((ua.match(/iPhone|iPod|Android|Blackberry|Windows Phone/i)) && !window.location.href.match(/fullsite=true/i)) {
        SendMail(0);
    } else if (ua.match(/iPad/i)) {
        SendMail(2);
    } else {
        SendMail('1');
    }
}



function BookHeaderHotel() {
    iRet = window.open("https://58e6be40ac559.sirvoy.me/?adults=2")

    var ua = navigator.userAgent;
    if ((ua.match(/iPhone|iPod/i) || ua.match(/Blackberry/i) || ua.match(/Android/i) || ua.match(/Windows Phone/i)) && !window.location.href.match(/fullsite=true/i)) {
        SendMail(0);
    }
    else if (ua.match(/iPad/i)) {
        SendMail(2);
    }
    else {
        SendMail('1');
    }
}


var dom = getObj

function getObj(objID) {
    if (document.getElementById) {
        if (document.getElementById(objID) == null)
            objID = "ctl00_cphContent_" + objID;

        return document.getElementById(objID)
    }
    else if (document.all) {
        if (document.all(objID) == null)
            objID = "ctl00_cphContent_" + objID;

        return document.all[objID];
    }
    else if (document.layers) {
        if (document.layers(objID) == null)
            objID = "ctl00_cphContent_" + objID;

        return document.layers[objID];
    }
}




var XmlHttp;
//Creating and setting the instance of appropriate XMLHTTP Request object to a “XmlHttp” variable  
function CreateXmlHttp() {
    //netscape.security.PrivilegeManager.enablePrivilege("UniversalBrowserRead");

    //Creating object of XMLHTTP in IE
    try {
        XmlHttp = new ActiveXObject("Msxml2.XMLHTTP");
    }
    catch (e) {
        try {
            XmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        catch (oc) {
            XmlHttp = null;
        }
    }
    //Creating object of XMLHTTP in Mozilla and Safari 
    if (!XmlHttp && typeof XMLHttpRequest != "undefined") {
        XmlHttp = new XMLHttpRequest();
    }
}

function RelativePath() {


    var url = self.location.href;
    url = url.toLowerCase();
    var path = '';

    var local = 'localhost:15209/';
    var server = 'server/';
    var live = 'bwportocallhotel.com/';

    if (url.lastIndexOf(local) > 1)
        path = "http://localhost:15209/";
    else if (url.lastIndexOf(live) > 1)
        path = "https://www.bwportocallhotel.com/";

    return path;
}

function SendMail(path) {

    $.ajax({
        type: "POST",
        data: { path: path },
        url: "/BookAjax/BookNow",
        success: function (result) {
        }
    });
}



function HandleResponseSendMail() {
    // To make sure receiving response data from server is completed	
    if (XmlHttp.readyState == 4) {	 // To make sure valid response is received from the server, 200 means response received is OK
        if (XmlHttp.status == 200) {		  // alert('Thank you for contacting Perimeter Reservations'); 
        }
        else {
            //alert("There was a problem retrieving data from the server." );
        }
    }
}
