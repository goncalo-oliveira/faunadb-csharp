#!/bin/sh

set -eou

apk add --no-cache -X http://dl-4.alpinelinux.org/alpine/edge/testing mono
apk add --no-cache ca-certificates
update-ca-certificates
# cert-sync /usr/local/share/ca-certificates
# export MONO_TLS_PROVIDER=legacy

dotnet test
