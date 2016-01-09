#!/bin/bash

echo "=== pre-deploy.sh start ==="
pushd ${TRAVIS_BUILD_DIR}
echo change working directory to TRAVIS_BUILD_DIR=${TRAVIS_BUILD_DIR}
zip binaries.zip -r Travel_Agent/bin/Release

echo "=== pre-deploy.sh end ==="
