$(document).ready(function () {
    document.title = 'User';

    $("#table-user").DataTable({
        "columns": [
            { "data": "Id", "name": "Id" },
            { "data": "FullName", "name": "FullName" },
            { "data": "DateOfBirth", "name": "DateOfBirth" },
            { "data": "Email", "name": "Email" },
            { "data": "Phone", "name": "Phone" },
            { "data": "Address", "name": "Address" },
        ],

        lengthMenu: [
            [5, 10, 25, 50, -1],
            [5, 10, 25, 50, 'Tất cả'],
        ],

        pageLength: 10,
        paging: true,
        language: {
            "lengthMenu": "Hiển thị _MENU_ dữ liệu",
            "emptyTable": "Không có dữ liệu",
            "info": "Hiển thị _START_ tới _END_ của _TOTAL_ dữ liệu",
            "infoEmpty": "Hiển thị 0 tới 0 của 0 dữ liệu",
            "search": "Tìm kiếm:",
            "searchPlaceholder": "Nhập tìm kiếm...",
            "select": {
                "cells": {
                    "1": "1 ô đang được chọn",
                    "_": "%d ô đang được chọn"
                },
                "columns": {
                    "1": "1 cột đang được chọn",
                    "_": "%d cột đang được được chọn"
                },
                "rows": {
                    "1": "1 dòng đang được chọn",
                    "_": "%d dòng đang được chọn"
                }
            },
            "paginate": {
                "first": "Đầu tiên",
                "last": "Cuối cùng",
                "next": "Sau",
                "previous": "Trước"
            },

        }

    });

});
