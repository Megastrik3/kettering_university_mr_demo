Laboratory 3  
Intro to Mixed Reality with Meta Quest 3

**Name 1:                                           \_**

**Name 2:                                           \_**

**Concepts:**

* Understanding the Difference Between Mixed Reality and Augmented Reality  
* Mixed Reality Development Basics in Unity


**Objectives:**

* Install MRUK into Unity  
* Download and Run Mixed Reality Demo Application  
* Interact with Demo Application  
* Customise Demo Application

**Hardware Needed:**

* Oculus Quest 3 or 3s  
* USB C cable (make sure it can connect the quest to your computer)

**Software Needed:**

* Oculus Link Software  
* Unity 6  
* Meta Quest Mobile App

**Files Needed:**

* [Unity Demo Project](https://github.com/Megastrik3/kettering_university_mr_demo)  
* [Custom Unity Asset](https://assetstore.unity.com/?category=3d%2Fprops&orderBy=4) (sort by free)

**Introduction:**

This laboratory exercise aims to give participants a taste of Mixed Reality (MR) development, specifically utilizing the Meta Quest 3 platform. The Meta Quest 3 represents a significant innovation in head-mounted displays, notable for its integration of advanced hardware components. Its MR functionality is underpinned by sophisticated depth sensors and high-fidelity color cameras. These integrated sensors enable the device to meticulously scan and construct a real-time, three-dimensional map of the user's physical environment. This foundational spatial understanding is crucial for the seamless blending of digital content with the real world. Consequently, users are afforded the unprecedented ability to intuitively interact with virtual objects that appear to exist within their actual physical space, thereby creating a rich and immersive mixed reality experience. This laboratory will explore the practical applications and technical considerations involved in designing and implementing such interactive MR scenarios.  
   
This laboratory exercise involves downloading and executing a mixed reality Unity application, followed by its customization to facilitate a deeper understanding of its functionalities. This lab assumes a successful completion of the lab assignments before it.

**Procedure:**  
Follow the procedures given below to complete the lab.

**Part 0: Quest Setup**

1. In order to use mixed reality, the Quest needs to model the environment that you will be using. To do this, we will create a spatial map of the room you will be doing this lab in. In the Quest settings, navigate to “*Settings \-\> Environment setup \-\> Space setup*”, then click the “*Set up*” button in the top right corner and follow the on screen instructions. Make sure your space has at least one table, and one window/poster/door. If one or more of these are not present, when editing the space after scanning, draw one using the edit mode.

**Part 1: My Reality**

1. Using GitHub, clone the [Unity Demo Project](https://github.com/Megastrik3/kettering_university_mr_demo) to your computer. This can be done by using [GitHub Desktop](https://github.com/apps/desktop), the command line, or by downloading the zip file and extracting it on your computer (pictured below).  
   ![][image1]

2. Open Unity Hub, and in the top right corner click the “*Add*” button, then “*Add project from disk.*” Navigate to the folder where you downloaded the Github repository to and click open. Note, the folder containing the files seen on Github (as seen above) should be the one opened. It will most likely be called “*kettering\_university\_mr\_demo*”. After adding the Unity project, it will appear in the Unity Hub project list. Click the title of the project to open it. (Note: Opening the project for the first time will take a while)

3. Once the project opens, Unity may ask you to restart the editor. If asked this question, click “*Restart Editor*”. Once the project has finished installing the required assets, you will be met with a screen that looks like the following:

![][image2]  
From this screen, navigate to the “*Assets/Scenes*” folder then double click on the “*MR\_DEMO*” scene to open it.  
![][image3]  
The editor should now look like this:  
![][image4]  
 

4. Now, in the top left corner click the “*File*” button then the “*Build Profiles*” button. This will open the Build Profiles dialog which is where we will configure the project build settings. In the left side menu, click the “*Android*” option, then the “*Switch Platform*” button that is on the bottom right side. This will change the platform that Unity will compile the project for.   
     
   (**Note:** The Quest 3/3(s) use Android as the operating system, meaning that Unity, Unreal Engine, and even Android Studio can be used to develop applications for the Quest.)  
     
   After Unity has finished switching the build platform, connect your Quest device to your computer and set the target device by expanding the “*Run Device*” drop down and selecting your Quest device. With your Quest device selected, click “*Build and Run*”, select a save location for the *.apk* file and give it a name. Your project will now be built and uploaded to the Quest (**Note**: This will take some time for the first build).  
     
   (**Note**: You may need to click the “*Refresh*” button before seeing your device in the drop down. If your device still does not show and you have confirmed that it is properly connected to your computer, it is possible that developer mode has not been enabled on the Quest. Please see previous lab assignments or [follow the instructions provided by Meta](https://developers.meta.com/horizon/documentation/native/android/mobile-device-setup/). For your organization, you can use a made up name. A registered organization name is not required despite instructions.)  
     
5. Once the build has finished, put on the headset and launch the app. Walk around the room and take note how it looks different. There should be some cubes in the room. Try picking the cubes up by pinching your index finger and thumb on the cube (or by making a full fist). If you run out of cubes (possibly by throwing them into space 😀), use the controllers and press the “*B*” button to spawn more cubes.  
     
     
   **Part 2: Your Own Reality**

1. Now it is time for you to customize the mixed reality experience. Navigate to the [Unity Asset Store](https://assetstore.unity.com/?category=3d%2Fprops&orderBy=4) and look for a free asset to add to your project. Once you find an asset to add, click “*Add to My Assets*” and the assets will be added to your account.  
2. Back in Unity, in the top menu, click “*Window \-\> Package Manager \-\> My Assets*”. This will display a list of the assets that are added to your account. Find the asset which you just added, and click “*Download*”. Click “*Import X.X to project*” then “*Import*”.![][image5]  
3. After the new assets have been imported, we need to replace the cube with the new asset. To do this we are going to replace the cube’s mesh and material with the newly added assets. The reason we are doing this instead of replacing the cube altogether is because the cube has several components that allow it to interact with the environment. We will explain what these are later and how to add them to new objects. For now, in the “*Project*” tab at the bottom, navigate to “*Assets/Prefabs*” then click on “*Cube*”.

![][image6]

4. In the “*Inspector*” on the right side of the screen, there will be a component called “*Cube (Mesh Filter)*” and “*Mesh Collider*”. Inside these components is the mesh or shape that the 3D object will use. To replace it, we are going to navigate to the folder of the new asset that we just added (in my case “*3D Stylized Chairs*”), then find the “*Mesh*” folder. Inside the mesh folder find the mesh of the object you want to replace the cube with, then drag it onto the mesh in the cube inspector.  
   ![][image7]  
5. You should now see the preview of the 3D object change to the new mesh that you just added. However, it will still have the same texture. To change that, navigate to the “*Materials*” (or similar) folder of the asset that you downloaded. After finding the material that you want to use, make sure the box is visible in the “*Inspector*” in the right panel, and drag the new material onto the preview of the 3D object.

    (**Note:** If the 3D object becomes bright pink after changing the material, that means that the rendered in Unity doesn’t know how to display the new material. This is okay. To fix this, click on the material that you just used on the 3D object, and at the top of the inspector, expand the “*Shader*” dropdown. Then select “*Universal Render Pipeline \-\> Lit*”. Finally, we need to fix the texture. Find the “*Texture*” (or similar) folder for the assets that you just downloaded, then drag your desired texture onto the small box to the left of the word “*Base Map*”.  
![][image8]  
**Explanation:** Why did we have to change the shader and the texture? This project uses the Universal Render Pipeline (URP) in order to properly display the passthrough into the virtual world from the real world. When we changed the shader, the texture was reset, so we needed to replace it.

6. Now, follow the steps from before to build and run the application and interact with your newly added object.

**Part 3: Features of the MRUK**  
The Mixed Reality Utility Kit (MRUK) is a SDK by Meta that helps streamline the development of mixed reality applications for the Quest using Unity. Some of these libraries can be seen by clicking on “*Meta \-\> Tools \-\> Building Blocks*” in the top bar. This will open a library of building blocks that can be added to scenes or specific objects. This demo project is using the “*Camera Rig*” which is mandatory for VR projects (the default camera needs to be deleted then replaced with this building block), “*Effect Mesh*” which handles the creation of the 3D space map so the real environment can be interacted with, and the “*Interactions Rig*” which is what allows 3D objects to be grabbed using your hands or the controllers. Please read through some of these building blocks to gain an understanding of what some of the capabilities of the Quest 3 are (Note: these building blocks are optional. The same functionality can be accessed through components by searching for the name of the building block you want).

**Post-lab Questions:**

1. What did you notice about the mixed reality environment when first launching the demo application? What were you able to make the cubes do? How did the cubes interact with the environment and your body?

2. What new asset did you decide to replace the cube with? Did this new asset interact any different with the environment than the cube? Show a picture (screenshot/video) of the asset that you added.

3. What does the “*Effect Mesh*” building block do? The effect mesh is very similar to a 3D scanner that is used to create 3D models from real world objects. What other applications do you see these sensors being used in a mixed reality application?

4. Out of the building blocks provided by meta, which do you think would make interesting additions to this demo application? Why do you think these would be good additions? Which building blocks would you like to use in your future projects?  
     
5. Mixed reality is a power feature of the Quest 3\. What applications in engineering, automotive, or other fields do you think a mixed reality application would have the greatest benefits? Why?