# Walkthrough - Spriha EduCare Website Updates (Uttara Relocation & 2026 Academic Refresh)

## Overview
The Spriha EduCare website has been updated to reflect the relocation from Savar to the **Uttara Campus**, refreshed to the **2026/2027 academic sessions**, updated with the newly released **Class 8 and 9 routines**, and fixed for critical form input validation bugs and asset references.

---

## Changes Made

### 1. Campus Relocation to Uttara
- **File Updated**: [SprihaEduCare_Web/Views/Shared/_Layout.cshtml](file:///D:/GitHub/SprihaEduCare/SprihaEduCare_Web/Views/Shared/_Layout.cshtml)
  - Replaced Savar branch details with:
    ```
    Campus Location (উত্তরা ক্যাম্পাস):
    House 34, Road 10, Sector 6, Uttara, Dhaka - 1230
    ```
  - Updated the Google Maps navigation link to direct to the Uttara location.
  - Corrected typos (`Goggle Maps` -> `Google Maps`), fixed Twitter/X font icon (`fa-brands fa-x-twitter`), and cleaned phone labels (`Mobile 1:`).

---

### 2. 2026 Academic Programs & Routine Downloads
- **Files Updated**:
  - [SprihaEduCare_Web/Views/Home/Programs.cshtml](file:///D:/GitHub/SprihaEduCare/SprihaEduCare_Web/Views/Home/Programs.cshtml)
  - [SprihaEduCare_Web/Views/Home/Index.cshtml](file:///D:/GitHub/SprihaEduCare/SprihaEduCare_Web/Views/Home/Index.cshtml)
- **Routines Published**:
  - Added PDF routines to `SprihaEduCare_Web/wwwroot/assets/routines/`:
    - `CLASS-08-ROUTINE-2026.pdf` (English & Bangla versions)
    - `CLASS-09-ROUTINE-2026.pdf` (Morning & Day shifts, Batches 01 to 04)
  - Added prominent download buttons in `Programs.cshtml` for students and parents.
- **Spelling & Batch Corrections**:
  - Corrected program batch dates from `২০২৫` to `২০২৬`.
  - Corrected Bengali spellings across all WhatsApp inquiry links (`বিকশিত দ্বাদশ`, `দীপ্ত নবম`, `স্ফুরিত দশম`, `প্রদীপ্ত একাদশ`).
  - Activated "Details" and "Enroll Now" buttons with pre-filled WhatsApp links.

---

### 3. Admission Form Bug Fixes
- **File Updated**: [SprihaEduCare_Web/Views/Home/Index.cshtml](file:///D:/GitHub/SprihaEduCare/SprihaEduCare_Web/Views/Home/Index.cshtml)
  - Fixed multiple fields (Guardian Name, Address, School/College) that were erroneously declared as `type="email"` with `placeholder="email@example.com"` and duplicate `id="userEmail"`.
  - Fields are now proper `type="text"` with unique IDs, names, and matching `<label for="...">` tags.
  - Added success confirmation banner display (`TempData["SuccessMessage"]`).
- **File Updated**: [SprihaEduCare_Web/Controllers/HomeController.cs](file:///D:/GitHub/SprihaEduCare/SprihaEduCare_Web/Controllers/HomeController.cs)
  - Added `[HttpPost] public IActionResult admissionForm(...)` action method to process submissions cleanly and redirect with a friendly confirmation.

---

### 4. Teacher Profiles & Subpage Metadata
- **File Updated**: [SprihaEduCare_Web/Views/Home/Teacher.cshtml](file:///D:/GitHub/SprihaEduCare/SprihaEduCare_Web/Views/Home/Teacher.cshtml)
  - Replaced all broken references to deleted `.jpeg` / `.jpg` images with active `.webp` assets in `teacher's img/`.
- **Files Updated**:
  - [SprihaEduCare_Web/Views/Home/AdviceOfSSC.cshtml](file:///D:/GitHub/SprihaEduCare/SprihaEduCare_Web/Views/Home/AdviceOfSSC.cshtml): Title corrected to `"এস.এস.সি. পরীক্ষার পরামর্শ"`.
  - [SprihaEduCare_Web/Views/Home/AdviceOfHSC.cshtml](file:///D:/GitHub/SprihaEduCare/SprihaEduCare_Web/Views/Home/AdviceOfHSC.cshtml): Title corrected to `"এইচ.এস.সি. পরীক্ষার পরামর্শ"`.

---

### 5. Build & Environment Pinning
- **File Created**: [global.json](file:///D:/GitHub/SprihaEduCare/global.json)
  - Pinned .NET SDK version to `8.0.428` to prevent MSBuild file access locks caused by the preview .NET 11 SDK.

---

## Verification Results

### Automated Build Check
```powershell
Set-Location SprihaEduCare_Web
dotnet build --no-restore
```
**Output**:
```
SprihaEduCare_Web -> D:\GitHub\SprihaEduCare\SprihaEduCare_Web\bin\Debug\net8.0\SprihaEduCare_Web.dll
Build succeeded.
    0 Error(s)
```

All modifications have been verified and build cleanly without any errors.
