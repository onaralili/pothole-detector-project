$(document).ready( function () {

    $('#table_id').DataTable({
        select: true,
        dom: 'Bfrtip',
         buttons: [
        {
            extend: 'csv',
            text: 'Export',
            exportOptions: {
                modifier: {
                    page: 'current'
                }
            }
        }
             ]
    });


} );

