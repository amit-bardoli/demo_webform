<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="Demo_ASPFrom.Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
     <link rel="stylesheet" href= 
"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/css/bootstrap-datepicker.min.css"> 
</head>
<body>
    <form id="form1" runat="server">
        <div class="row container d-flex justify-content-center">
            <div class="col-6 col-md-4">
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                <div class="form-group">
                    
                        <label>Name:</label>
                    <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
                    <asp:HiddenField ID="hfId" runat="server" />
                        <%--<input class="form-control" type="text" placeholder="" aria-label="default input example">--%>
                    
                </div>
                 <div class="form-group">
                    
                        <label>Password:</label>
                      <asp:TextBox ID="txtPassword" runat="server" class="form-control"></asp:TextBox>
                       <%-- <input class="form-control" type="text" placeholder="" aria-label="default input example">--%>
                    
                </div>
                 <div class="form-group">
                    
                        <label>City:</label>
                        <asp:DropDownList ID ="ddlCity" runat="server" class="form-control">
                             <asp:ListItem Value="">--Select--</asp:ListItem>
                          <%--  <asp:ListItem Value="Dubai">Dubai</asp:ListItem>
                             <asp:ListItem Value="Abu Dhabi">Abu Dhabi</asp:ListItem>
                             <asp:ListItem Value="Sharjah">Sharjah</asp:ListItem>--%>

                        </asp:DropDownList>
                    
                </div>
                 <div class="form-group">
                    
                        <label>Gender:</label>
                       <asp:RadioButtonList ID="rblGender" runat="server" class="form-control" RepeatDirection="Horizontal">
                           <asp:ListItem Value="M">Male</asp:ListItem>
                           <asp:ListItem Value="F">Female</asp:ListItem>
                       </asp:RadioButtonList>
                    
                </div>
                 <div class="form-group">
                    
                        <label>Email:</label>
                          <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
                    
                </div>
                 <div class="form-group">
                    
                        <label>Image:</label>
                      <asp:FileUpload ID="fuImage" runat="server" class="form-control"/>
                     <asp:HiddenField ID="hfImage" runat="server" />
                    
                </div>
                 <div class="form-group">
                    
                        <label>Status:</label>
                       <asp:CheckBox ID="chkStatus" runat="server" class="form-control" />
                    
                </div>
                 <div class="form-group">
                    
                        <label>Salary:</label>
                         <asp:TextBox ID="txtSalary" runat="server" class="form-control"></asp:TextBox>
                    
                </div>
                 <div class="form-group">
                    
                        <label>Birthdate:</label>
                         <asp:TextBox ID="txtBirthdate" runat="server" class="form-control" ClientIDMode="Static"></asp:TextBox>
                    
                </div>

                <div class="col-lg-4 col-auto form-group">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary btn-block" OnClick="btnSubmit_Click" />
                    <a href="default.aspx" class="btn btn-primary btn-block"> Cancel</a>
                     </div>
            </div>
        </div>
    </form>
</body>
    <script src="https://code.jquery.com/jquery-3.6.1.min.js"       integrity="sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ="     crossorigin="anonymous">   </script> 
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
     <script src= 
"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/js/bootstrap-datepicker.min.js"> 
    </script> 
    <script> 
        $(function () { 
            $("#txtBirthdate").datepicker({
                format: 'dd/mm/yyyy',
                autoclose: true,  
                todayHighlight: true, 
            }).datepicker(); // 'update', new Date()
        }); 
    </script> 

</html>
