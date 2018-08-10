# kickr
This project is used in the [Build an augmented reality app on Root insurance](https://make.offerzen.com/course/root-insurance-augmented-reality) course, at [Make by OfferZen](https://make.offerzen.com/).

You can see a [walkthrough here](https://drive.google.com/a/fireid.com/file/d/1J9nmuZbas7Fu9cUyj-eBiqYLIi1205Wq/view?usp=sharing). The important topics are listed bellow:
- Vuforia register [00:15]()
- Unity overview [01:27]()
- Add Vuforia License Key [02:10]()
- Activate Vuforia AR Support [02:44]()
- Create Vuforia database and targets [03:36]()
- Import Vuforia database [06:50]()
- Manipulating and testing ImageTarget [07:10]()
- Add second ImageTarget and Prefab [09:37]()
- Interaction between ImageTargets with a script [12:25]()
- Coliding the capsule with the ball [16:30]()
- Reset ball position [19:35]()
- Root API call [20:32]()
- Questions and Bye! [23:38]()

To get this project running locally, you need to:
- Install Unity and Vuforia
- Register at [Vuforia](https://developer.vuforia.com/vui/auth/register) and get an App License Key
- Create a database and two targets, [egg1](https://github.com/OfferZen-Make/arinsuretech-kicker/blob/master/Assets/egg1.jpeg) and [egg2](https://github.com/OfferZen-Make/arinsuretech-kicker/blob/master/Assets/egg2.jpeg)
- Download the database and import into Unity
- Open the project on Unity
- In the `Assets -> Scenes`, open the `SampleScene`
- In `Assets -> Resources`, open the `VuforiaConfiguration`. At the Inspector, add the generated App License Key
- In the `Edit -> Project Settings -> Player` make sure the `Vuforia Augmented Reality Support` is checked
- In the `ImageTarget` GameObject, select the imported targed in `Image Target Behaviour`
- Click the `Play` button and have fun!
