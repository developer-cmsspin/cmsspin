![alt text](http://dev.cmsspin.com/Spin/Themes/SpinWeb/Resource/img/logo-spin-color.png)
# CMS SPIN V 0.1.23 (Release Candidate)
### *Date: 3 JuL 2019 22:00*
[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

CMS BUILD TO .NET CORE. BY WEB DEVELOP.

## New Features

  - Permissions for see configuration per group
  - Update files with update nuget
  - Add Method Extension ToSql for IQuerable
   ```csharp
   var stringSQL = query.ToSql(); 
   ```
  - Add Complile Query Pagination
   ```csharp
   static  PaginatedListCompile<LeadItem> Comp = new PaginatedListCompile<LeadItem>((Ctx, pageIndex, pageSize, Parameters) =>
   {
        
        IQueryable<LeadItem> DataContextInternal = Ctx.Data.Include(a => a.Estate);
        //Filter UserAdmin
        ConfigurationLeadCompile Configuration = Parameters as ConfigurationLeadCompile;

        return DataContextInternal;
    });
   ```
  > *Important:* <br>
  > User variable static

   - Add Complile Query for List
   ```csharp
   static ListCompile<EstateItem> SelectAllCompile = new ListCompile<EstateItem>((ctx Parameters)=>
   {
      return ctx.Data.Include(a => a.Towers).Include(a => a.Place);
   });
   ```
  > *Important:* <br>
  > User variable static

  - Add Complile BaseBL per call
   ```csharp
  private static BaseListBLCompile<T> SelectByInternalCompile = new BaseListBLCompile<T>((ctx, BL, Parameters) =>
        {
            Expression<Func<T, bool>> Value = (Expression<Func<T, bool>>)Parameters;
            return BL.SelectBy(Value);
        });
   ```
  > *Important:* <br>
  > User variable static

  - Add Complile BaseBL
   ```csharp
  private static BaseListBLCompile<T> SelectByInternalCompile = new BaseListBLCompile<T>((ctx, BL, Parameters) =>
        {
            Expression<Func<T, bool>> Value = (Expression<Func<T, bool>>)Parameters;
            return BL.SelectBy(Value);
        });
   ```
   ```csharp
   TowerBL BLA = new TowerBL();
   var Result = BLA.SelectAllPerPageCompile(1, 20);
   ```


## Issuses Fixed

  - Upload multiple Images
  - Mark border red textarea required
  - Add required field for module Estate and Lead 
  - Only show Leads Enabled for Agents
  - Fix template service
  - Show template REST Service5
  - History showing other leads taken
  - improve the ALL funtion with compile queries

  

## Deploy

- Change Program.cs
```csharp
public class Program: SpinProgram<Startup>
{
    /// <summary>
    /// Main Call
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        CallMain(args);
    }
}   
```


- Please execute this script for update table "groups"
```sql
ALTER TABLE Security_Group
ADD ShowConfigurationDashboard bit NULL;

GO

UPDATE Security_Group
SET ShowConfigurationDashboard = 0;

GO

UPDATE Security_Group
SET ShowConfigurationDashboard = 1
WHERE IdGroup = 1;

GO

ALTER TABLE Security_Group
ALTER COLUMN  ShowConfigurationDashboard bit NOT NULL;

GO
```

- Please execute this script for update table "permissions"
```sql
ALTER TABLE Security_GroupPermission
ADD ShowConfiguration bit NULL;

GO

UPDATE Security_GroupPermission
SET ShowConfiguration = 0;

GO

ALTER TABLE Security_GroupPermission
ALTER COLUMN  ShowConfiguration bit NOT NULL;

GO
```


> *Important:* <br>
> Run script for production.

  - Add Method Extension ToSql for IQuerable
   ```csharp
   var stringSQL = query.ToSql(); 
   ```
  - Add Complile Query Pagination
   ```csharp
   static  PaginatedListCompile<LeadItem> Comp = new PaginatedListCompile<LeadItem>((Ctx, pageIndex, pageSize, Parameters) =>
   {
        
        IQueryable<LeadItem> DataContextInternal = Ctx.Data.Include(a => a.Estate);
        //Filter UserAdmin
        ConfigurationLeadCompile Configuration = Parameters as ConfigurationLeadCompile;

        return DataContextInternal;
    });
   ```
  > *Important:* <br>
  > User variable static

   - Add Complile Query for List
   ```csharp
   static ListCompile<EstateItem> SelectAllCompile = new ListCompile<EstateItem>((ctx Parameters)=>
   {
      return ctx.Data.Include(a => a.Towers).Include(a => a.Place);
   });
   ```
  > *Important:* <br>
  > User variable static

  - Add Complile BaseBL per call
   ```csharp
  private static BaseListBLCompile<T> SelectByInternalCompile = new BaseListBLCompile<T>((ctx, BL, Parameters) =>
        {
            Expression<Func<T, bool>> Value = (Expression<Func<T, bool>>)Parameters;
            return BL.SelectBy(Value);
        });
   ```
  > *Important:* <br>
  > User variable static

  - Add Complile BaseBL
   ```csharp
  private static BaseListBLCompile<T> SelectByInternalCompile = new BaseListBLCompile<T>((ctx, BL, Parameters) =>
        {
            Expression<Func<T, bool>> Value = (Expression<Func<T, bool>>)Parameters;
            return BL.SelectBy(Value);
        });
   ```
   ```csharp
   TowerBL BLA = new TowerBL();
   var Result = BLA.SelectAllPerPageCompile(1, 20);
   ```
   - Updater remote 

  > *Important:* <br>
  > Execute bower when finish updated

### *Development by CMS SPIN Delevoper Team*