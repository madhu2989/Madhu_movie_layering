<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <script src="Scripts/jquery-1.10.2.min.js"></script>  
    <script src="Scripts/jquery.validate.min.js"></script>    
    <script type ="text/javascript" >                
        $(document).ready(function () {  
            $("#form1").validate({  
                rules: {  
                    //This section we need to place our custom rule   
                    //for the control.  
                    <%=txtName.UniqueID %>:{  
                        required:true  
                    },   
                },  
                messages: {  
                    //This section we need to place our custom   
                    //validation message for each control.  
                    <%=txtName.UniqueID %>:{  
                          required: "Name is required."  
                      },  
                },  
            });  
        });         
    </script>  
    <br />  
   
    Name <asp:TextBox ID="txtName" runat="server"></asp:TextBox>  
    <br />  
    <br />  
   <asp:Button ID="btnSubmit" runat="server" Text="Submit" />   
    </div>
    </form>
</body>
</html>
