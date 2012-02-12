function browseToFileManagerServer(target, url) {
    var width = 800;
    var height = 600;

    var iLeft = (window.screen.width - width) / 2;
    var iTop = (window.screen.height - height) / 2;

    var sOptions = "toolbar=no,status=no,resizable=yes,dependent=yes,scrollbars=yes,center=1";
    sOptions += ",width=" + width;
    sOptions += ",height=" + height;
    sOptions += ",left=" + iLeft;
    sOptions += ",top=" + iTop;


    var result = window.showModalDialog('http://http://localhost:50096/Scripts/fckeditor/editor/filemanager/browser/default/browser.html?Type=Image&Connector=http%3A%2F%2Flocalhost%3A60646%2FScripts%2Ffckeditor%2Feditor%2Ffilemanager%2Fconnectors%2Fasp%2Fconnector.asp', "File/Image Management Server", sOptions);
    if (result) {
        target.value = result;
    }
};