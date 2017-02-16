export default {
  getData() {
    return fetch('/test/getdata').then(x => x.json());
  }
}