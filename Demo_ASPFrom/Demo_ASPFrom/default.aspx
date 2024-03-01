<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Demo_ASPFrom._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="grvRegistration" runat="server" AutoGenerateColumns="false"  OnRowCommand="grvRegistration_RowCommand"  >
                
                <Columns>
                    <asp:TemplateField ItemStyle-Width="30px" HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-Width="30px" HeaderText="Password">
                        <ItemTemplate>
                            <asp:Label ID="lblPassword" runat="server" Text='<%#Eval("Password")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-Width="30px" HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="lblCity" runat="server" Text='<%#Eval("City")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-Width="30px" HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="lblGender" runat="server" Text='<%#Eval("Gender")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-Width="30px" HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-Width="30px" HeaderText="Image">
                        <ItemTemplate>
                              <img src='<%# "Doc/"+ Eval("Image")%>' alt='<%# Eval("Image")%>' height="50px" width="50px" />
                          
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-Width="30px" HeaderText="Status">
                        <ItemTemplate>
                            <asp:Label ID="lblStatus" runat="server" Text='<%#Eval("Status")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-Width="30px" HeaderText="Salary">
                        <ItemTemplate>
                            <asp:Label ID="lblSalary" runat="server" Text='<%#Eval("Salary")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-Width="30px" HeaderText="Birthdate">
                        <ItemTemplate>
                            <asp:Label ID="lblBirthdate" runat="server" Text='<%#Eval("Birthdate")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkRemove" runat="server" CommandName="Delete" CommandArgument='<%# Eval("id")%>' OnClientClick="return confirm('Do you want to delete?')" Text="Delete"></asp:LinkButton>
                            
                            <a id="lnkEdit" runat="server" href='<%# String.Format("Reg.aspx?ID={0}", Eval("Id")) %>'>Edit</a>
                        </ItemTemplate>                        
                    </asp:TemplateField>
                     <asp:CommandField ShowEditButton="false" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
<script src="https://code.jquery.com/jquery-3.6.1.min.js" integrity="sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ=" crossorigin="anonymous">   </script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</html>
