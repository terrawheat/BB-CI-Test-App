import dataService from './data-service';
import $ from 'jquery';

dataService.getData().then(data => {
  let $foo = $('#foo');
  let $baz = $('#baz');

  $foo.text(data.foo);
  $baz.text(data.baz);
});