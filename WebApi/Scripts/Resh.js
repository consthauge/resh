function returnResh() {
    var reshId = $('#reshId').val();
    $(".resh .resh-info").html("");

    $.getJSON("/resh/" + reshId).done(function (data) {
        console.log(data);
        var name = JSON.stringify(data.Name).replace(/['"]+/g, '');
        var organizationalDesignation = JSON.stringify(data.OrganizationalDesignation.CodeText).replace(/['"]+/g, '');
        var parentName = JSON.stringify(data.ParentName).replace(/['"]+/g, '');
        var output = "<h2>" + name + "</h2>";
        output += "<strong>Resh-id: </strong>" + reshId + "<br />";
        output += "<strong>Organisatorisk betegnelse: </strong>" + organizationalDesignation + "<br />";
        if (parentName != null) {
            output += "<strong>Hovedorganisasjon: </strong>" + parentName;
        }

        $(".resh .resh-info").html("<div class=\"wrapper\">" + output + "</div>");
    }).fail(function (jqxhr) {
        var error = "<span class=\"error\">Det var en feil med forespørselen din.<br />Husk å søke med en RESH-id.</span>";
        $(".resh .resh-info").html(error);
    });

    //$.getJSON("/resh/" + reshId, function (data) {
    //    var name = JSON.stringify(data.Name);
    //    var output = "<h2>" + name + "</h2><ul>";
    //    for (var i in data.Children) {
    //        output += "<li>" + data.Children[i].Name + "</li>";
    //    }
    //    output += "</ul>"
    //    $(".resh .resh-info").html(output);
    //});
}
