body {
    margin: 0;
    padding: 0;
    background-color: #f4f4f4;
}

main {
    max-width: 100%;
    width: 1440px;
    height: 696px;
    margin: 0 auto;
}

.gallery {
    display: flex;
    flex-wrap: wrap;
    align-items: center;

}

.gallery-style {
    flex: 1 1 calc(33.333% - 10px);
    max-width: calc(33.333% - 10px);
    overflow: hidden;
    cursor: pointer;
    width: 360px;
    height: 300px;
    margin-bottom: 10px;
    margin-right: 10px;
}

.gallery-image {
    max-width: 100%;
    height: auto;
}

.gallery-link {
    width: 360px;
    height: 300px;
}