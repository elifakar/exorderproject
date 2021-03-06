/*
Name: 			Tables / Advanced - Examples
Written by: 	Okler Themes - (http://www.okler.net)
Theme Version: 	2.1.1
*/

(function ($) {

	'use strict';

	var datatableInit = function () {
		var $table = $('#datatable-tabletools');

		var table = $table.dataTable({
			sDom: '<"text-right mb-md"T><"row"<"col-lg-6"l><"col-lg-6"f>><"table-responsive"t>p',
			buttons: ['print', 'excel', 'pdf']
		});

		$('<div />').addClass('dt-buttons mt-2 pb-1 text-right').appendTo('#datatable-tabletools_wrapper');

		$table.DataTable().buttons().container().appendTo('#datatable-tabletools_wrapper .dt-buttons');

		$('#datatable-tabletools_wrapper').find('.btn-secondary').removeClass('btn-secondary').addClass('btn-primary btn-xs');
	};

	$(function () {
		datatableInit();
	});

}).apply(this, [jQuery]);
