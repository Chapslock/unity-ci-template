## Sample Project for Unity development

### Sample EditMode/PlayMode tests implemented

### Sample Project structure implemented

### Sample Github Actions implemented for continous testing and building
#### To Start using Actions:
#### NB! These steps should be done only once after forking the repo!
* Manually run the "Get Unity license activation file"  workflow.
* Download the manual activation file that now appeared as an artifact and extract the Unity_v20XX.X.XXXX.alf file from the zip.
* Visit "license.unity3d.com" and upload the Unity_v20XX.X.XXXX.alf file.
* You should now receive your license file (Unity_v20XX.x.ulf) as a download. It's ok if the numbers don't match your Unity version exactly.
* Open Github > <Your repository> > Settings > Secrets.
* Create the following secrets;
* UNITY_LICENSE - (Copy the contents of your license file into here)
* UNITY_EMAIL - (Add the email address that you use to login to Unity)
* UNITY_PASSWORD - (Add the password that you use to login to Unity)

### Deployment available on tagged commits
