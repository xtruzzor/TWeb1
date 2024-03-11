@section Scripts {
    @Scripts.Render("~/bundles/unobstrusive/js")

    <script type="text/javascript">
        function succes(data){
            if (data.RedirectUrl) {
                window.location.href = data.RedirectUrl;
            } else {
            $("#resultTarget").text(data.msg);

            }
        }

        function fail(data) {
            $("#resultTarget").text(data);
        }

    </script>
}