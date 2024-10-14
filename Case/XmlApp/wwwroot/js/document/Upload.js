$(document).ready(() => {
    $(".start").hide();
});

var Toast = Swal.mixin({
    toast: true,
    position: 'bottom-end',
    showConfirmButton: false,
    timer: 3000
});

const dropzone = new Dropzone("div.my-dropzone", { url: "/Home/Upload" });
Dropzone.autoDiscover = false

var previewNode = document.querySelector("#template")
previewNode.id = ""
var previewTemplate = previewNode.parentNode.innerHTML
previewNode.parentNode.removeChild(previewNode)

var myDropzone = new Dropzone(document.body, {
    url: "/Home/Upload",
    thumbnailWidth: 80,
    thumbnailHeight: 80,
    parallelUploads: 20,
    previewTemplate: previewTemplate,
    autoQueue: true,
    previewsContainer: "#previews",
    clickable: ".fileinput-button",
    acceptedFiles: ".xml"
})

myDropzone.on("success", function (file, response) {
    Toast.fire({
        icon: 'success',
        title: 'Başarıyla Yüklendi!',
        text: 'Dosyanız başarıyla yüklendi.',
    });
})

myDropzone.on("error", function (file, response) {
    Toast.fire({
        icon: 'error',
        title: 'Hata!',
        text: 'Dosya yüklenirken bir hata oluştu.',
    });
})

myDropzone.on("addedfile", function (file) {
    file.previewElement.querySelector(".start").onclick = function () { myDropzone.enqueueFile(file) }
    $(".start").hide();
})

myDropzone.on("totaluploadprogress", function (progress) {
    document.querySelector("#total-progress .progress-bar").style.width = progress + "%"
})

myDropzone.on("sending", function (file) {
    document.querySelector("#total-progress").style.opacity = "1"
    file.previewElement.querySelector(".start").setAttribute("disabled", "disabled")
})

myDropzone.on("queuecomplete", function (progress) {
    document.querySelector("#total-progress").style.opacity = "0"
})

document.querySelector("#actions .start").onclick = function () {
    myDropzone.enqueueFiles(myDropzone.getFilesWithStatus(Dropzone.ADDED))
}
document.querySelector("#actions .cancel").onclick = function () {
    myDropzone.removeAllFiles(true)
}