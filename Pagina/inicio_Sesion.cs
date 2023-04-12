
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
<script>
   $(function() {
      var url = "some_url";
      $.ajax(url,
      {
         if (statusCode == 200) {
           document.location.href = url;
         }
         else {
           alert('Incorrect password')
         }
      }
   });   
});
</script>

<input type="password" /><a href="javascript:void(0)">Login</a>