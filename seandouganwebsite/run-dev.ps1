$process = Start-Process -FilePath 'run-dev.bat' -NoNewWindow -Wait -PassThru
if ($process.ExitCode -ne 0) {
    exit 1
}
