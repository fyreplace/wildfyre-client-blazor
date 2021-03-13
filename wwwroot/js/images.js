function resizeData(base64, mime, maxSurface) {
    const img = document.createElement('img')
    img.crossOrigin = "anonymous";
    img.src = "data:" + mime + ";base64," + base64

    const canvas = document.createElement("canvas")
    const factor = Math.max((img.width * img.height) / maxSurface, 1)
    canvas.width = img.width / factor
    canvas.height = img.height / factor

    const ctx = canvas.getContext('2d')
    ctx.drawImage(img, 0, 0, canvas.width, canvas.height)
    ctx.save()
    return canvas.toDataURL('image/jpeg', 0.5).replace(/.*base64,/, "")
}
