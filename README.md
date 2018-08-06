# kickr
This project is used in the `Build an augmented reality app on Root insurance` course, at [Make by OfferZen](https://make.offerzen.com/).

You can see a walkthrough [here](). The important topics are listed bellow:
- Setup Vuforia...
- ...

To get this project running locally, you need to:
- Install Unity and Vuforia
- Register at [Vuforia](https://developer.vuforia.com/vui/auth/register) and get an App License Key
- Create a database and two targets, using [this]() and [this]() images
- Download the database and import into Unity
- Open the project on Unity
- In the `Assets -> Scenes`, open the `SampleScene`
- In `Assets -> Resources`, open the `VuforiaConfiguration`. At the Inspector, add the generated App License Key
- In the `Edit -> Project Settings -> Player` make sure the `Vuforia Augmented Reality Support` is checked
- In the `ImageTarget` GameObject, select the imported targed in `Image Target Behaviour`
- Click the `Play` button and have fun!
