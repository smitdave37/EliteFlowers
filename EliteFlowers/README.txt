Group: Zeta
Members: Smit Dave
		 Kejan Jada
		 Amandeep Kaur
	 


Topic: Flower
Web-AppName: Elite Flowers

Update This in Nuget Manager:
Update-Database -Context EliteFlowersContext

2024-02-15
1830
Review : Get Started, Add a Controller, and Add a View

Reserch:

Scotts Flowers NYC (https://www.scottsflowersnyc.com/):

Scotts Flowers NYC is a boutique flower shop located in New York City. They offer a wide range of floral arrangements for various occasions, including weddings, corporate events, and everyday occasions.
The website features a diverse selection of bouquets, plants, and gifts, with options for customization and personalization.
Scotts Flowers NYC emphasizes high-quality floral designs and excellent customer service, catering to both individual customers and businesses in the NYC area.


PlantShed (https://www.plantshed.com/tootsie):

PlantShed is a florist and garden center based in New York City, known for its extensive collection of plants, flowers, and gifts.
The website showcases a variety of floral arrangements, planters, and gift baskets suitable for different occasions and preferences.
PlantShed offers delivery services in NYC, providing convenience for customers looking to send floral gifts or enhance their living spaces with greenery.


French Florist (https://www.frenchflorist.com/sweet-champagne/):

French Florist is a long-standing floral company serving the Los Angeles area since 1978. They specialize in elegant floral designs for weddings, events, and everyday occasions.
The website features a curated selection of floral arrangements, including bouquets, centerpieces, and sympathy flowers, reflecting French Florist's commitment to quality and creativity.
French Florist offers local delivery in Los Angeles and ensures customer satisfaction through personalized service and attention to detail.


erra Bella Flowers (https://www.terrabellaflowers.com/products/spellbound):

Terra Bella Flowers is a boutique florist located in Portland, Oregon, known for its distinctive floral designs inspired by nature and seasonal blooms.
The website showcases a range of artistic arrangements, including hand-tied bouquets, terrariums, and garden-inspired creations.
Terra Bella Flowers emphasizes sustainability and eco-conscious practices in sourcing their flowers and materials, aligning with Portland's ethos of environmental stewardship.


Flower Station (https://www.flowerstation.co.uk/a-parisian-romance/):

Flower Station is a London-based florist offering a wide selection of fresh flowers, bouquets, and floral gifts for delivery across the UK.
The website features a diverse range of floral arrangements, from classic roses to contemporary designs, suitable for various occasions and preferences.
Flower Station provides same-day delivery options and strives to ensure the freshness and quality of their flowers, earning a reputation for reliability and customer satisfaction.


Kensington Flowers (https://www.kensingtonflowers.co.uk/product/vintage-flower-bottles/):

Kensington Flowers is a florist located in London's prestigious Kensington neighborhood, specializing in bespoke floral designs and luxury arrangements.
The website showcases an array of elegant floral creations, including hand-tied bouquets, vase arrangements, and wedding flowers, crafted with attention to detail and artistic flair.
Kensington Flowers offers delivery services throughout London, catering to discerning clients seeking premium-quality blooms and personalized service.


Grace & Thorn (https://graceandthorn.com/collections/flowers/products/wildthing):

Grace & Thorn is a contemporary florist based in London, known for its unique and unconventional approach to floral design.
The website features a curated selection of "wild and wonderful" floral arrangements, characterized by their naturalistic style and bold, avant-garde aesthetic.
Grace & Thorn offers delivery across London and has gained a cult following for their distinctive floral creations, which often incorporate unusual botanicals and textures.

Twig & Arrow (https://twigandarrow.com/collections/flowers-1/products/market-style-bouquet-subscription):

Twig & Arrow is a boutique flower shop located in Nashville, Tennessee, specializing in seasonal blooms and custom floral arrangements.
The website offers a subscription service for market-style bouquets, providing customers with regular deliveries of fresh, hand-picked flowers sourced from local farms and growers.
Twig & Arrow emphasizes sustainability and community engagement, supporting local agriculture and promoting the beauty of seasonal flowers through their subscription service.

Introduction to Zeta Group's Flower Collection:

:-> Welcome to the world of Zeta Group's Flower Collection, where beauty meets elegance in every petal. 
:-> Led by members Smit Dave, Kejan Jada and Amandeep Kure.
:-> We have Decided to Choose these topics Types, Colors, Prices, Images, and Quantity.
:-> We have take content from these websites.
Elite Flower Overview:

:-> Elite Flower is a design pattern widely adopted in software development to organize code effectively, promoting separation of concerns and 
    modularity. It comprises three primary components:

:-> Model: The model represents the application's data and encapsulates the business logic. Its primary responsibility is to manage data and handle 
    any modifications or updates. Additionally, the model notifies observers, typically views, about any changes in the data. This ensures that the user
    interface remains synchronized with the underlying data state.

:-> View: The view component represents the user interface and is responsible for presenting data to the user in a readable format. It receives input from
    the user, such as clicks or keyboard events, and communicates these interactions back to the model. By doing so, the view ensures that user actions 
    trigger appropriate responses from the application.

:-> Controller: Acting as an intermediary between the model and the view, the controller component manages user interactions and updates. It receives input 
    from the view, processes it, and potentially modifies the model accordingly. The controller then updates the view to reflect any changes in the data or 
    application state. This separation of concerns ensures that each component focuses on its specific role, enhancing code modularity and maintainability.

:-> Details: We are desided to chose five topics (FlowerType, Size, Color, Price, Quantity).

:-> It's important to note that this overview provides a basic understanding of the Elite Flower pattern, and actual implementations may vary depending on 
    the programming language and framework being used. The fundamental principle, however, remains consistent: separating concerns to make code modular and
    easier to maintain. 

Observation: This is a very basic overview, and actual implementations may vary depending on the programming 
			 language and framework you're using. The key idea is to separate concerns, making your code more 
			 modular and maintainable.
.
.
.
.
2024-02-15
1945
Review : Add a Model

Model: Represents the application's data and business logic. It is responsible for data storage, retrieval, and manipulation.
:-> Adding a model to an ASP.NET Core Elite Flower app involves defining data structures that represent the application's business entities. 
:-> These models are typically used to interact with a database, process user input, and facilitate communication between different 
 components of the Elite Flower architecture.


:-> The DataType attribute, when applied to a property like ReleaseDate, specifies the type of data expected for that property. In this case, by specifying
    DataType.Date, it indicates that the ReleaseDate property should only contain date information, without any time component.

:-> With this attribute:

	A).User Input: Users are not required to enter time information when providing input for the ReleaseDate property. 
		       This simplifies the user input process and ensures that only the date portion needs to be entered.

	B).Display: When displaying the ReleaseDate property in the application's user interface, only the date information is shown to the user. 
		    The time component is omitted, leading to a cleaner and more focused presentation of the data.

Output:->

				Elite Flowers
Add Flowers


FlowerType	Size	 Color	  Price	  Quantity	
Rose		Mediam	 Red	  20.00	  3.00	   Edit | Details | Delete
Sun Flower	Large	 Yellow	  20.00	  2.00	   Edit | Details | Delete
Tulip		Small	 Purple	  10.00	  5.00	   Edit | Details | Delete
Orchid		Medium	 White	  30.00	  1.00	   Edit | Details | Delete
Marigold	Large	 Yellow	  5.00	  2.00	   Edit | Details | Delete 



Observation:
	:Incorporating a model into an ASP.NET Core Elite Flower application entails establishing data structures that represent business entities. 
	:These structures are utilized to interact with a database and manage user input. Models play a crucial role in facilitating communication between
         various Elite Flower components, enabling seamless handling of data storage, retrieval, and manipulation tasks. Additionally, employing the 
	 DataType attribute on ReleaseDate simplifies user input by specifying date-only data, thereby improving the user experience.
.
.
.
.
2024-02-17
1306
Review : work with a database (SQL)
20240219003744_InitialCreate.cs <--: Initial File.

:-> Working with a database entails interacting with a structured collection of data to efficiently store, retrieve, update, and manage information.
:-> A Database Management System (DBMS) refers to software designed to facilitate the creation, maintenance, and manipulation of databases. 
:-> Popular examples of DBMS include MySQL, PostgreSQL, Oracle, and Microsoft SQL Server. These systems offer a range of functionalities, such as data 
    storage, retrieval, indexing, querying, and security features, to support efficient data management.
:-> Popular examples include MySQL, PostgreSQL, Oracle, and Microsoft SQL Server.

:-> When you "seed" the database, it means populating it with initial data so that the application starts with some predefined records. 
:-> This can be beneficial for testing, demonstrating functionality, or simply providing default values.
:-> database seeding is a valuable practice in software development, as it contributes to improved testing, user experience, and efficiency in managing
    data-driven applications.


Output:->


	Create

Flower

Title:  Deadpool
Date :  yyyy-mm-dd
Genre:	Action
Price:	100.00

FlowerType : Sun Flower
Quantity   : 3
Color	   : Yellow
Size	   : Large
Price	   : 55

Create
Back to List


Observation:
	:Database seeding is the act of filling the database with initial data. This is advantageous for testing, demonstrating 
	 functionality, or supplying default values. It guarantees that the application begins with predetermined records, ultimately 
	 enhancing efficiency and user experience
.
.
.
2024-02-18
1551
Review : controller methods and views

:-> Controllers handle the logic of your application, including processing input, interacting with the model (database), and rendering views. 
:-> Views are the presentation layer of your application, typically containing HTML, CSS, and sometimes JavaScript to display data to users.

:-> Controller Actions: 
	Controller actions are methods within the controller component of an Elite Flower framework. They handle incoming
	requests from users, process data, interact with the model (database), and determine which view to render. 
:-> Controller actions encapsulate the logic of your application and serve as the bridge between the user interface and the data layer.

:-> Views:
	:Views play a vital role in conveying data to users in a comprehensible format, often using HTML with dynamic content. 
	:They are distinct from both the controller and model components, maintaining a clear distinction of responsibilities. 
	:Views receive data from the controller and utilize templates or layouts to produce the final HTML output delivered to the user's browser.


Observation:
	:Controller actions consist of methods situated within the controller component of an Elite Flower framework. They manage incoming requests 
	 from users, handle data processing, interact with the model (typically the database), and decide which view to display. Essentially, controller
	 actions encapsulate the core logic of your application, serving as the intermediary between the user interface and the data layer.
.
.
.
.
2024-02-19
0913
Review : Add a Search and A new File

Model:

:-> Add search: 
	:Integrating search functionality enables users to locate specific information within your application.
	:this entails developing a search form where users can input keywords or filters. Subsequently, the backend processes this input to retrieve
	 relevant data from the database. The search results are then presented to the user, commonly in a list or grid format.

:-> Add a new field: 
	:When adding a new field, you'll first need to adjust your database schema by introducing a new column or attribute to store additional data
	 relevant to your application's domain. Following the schema update, you must also make corresponding adjustments to your application's codebase.
	 This involves modifying forms, database queries, and views to accommodate the new field and ensure seamless interaction with the data.
:-> This could be anything from adding a new "description" field to a product table to adding a "birthdate" field to a user profile.
    that the application remains synchronized with the updated database schema, allowing for seamless interaction with the new field's data. This 
    ensures that users can effectively utilize the new functionality and that the application continues to meet their needs.


Observation:
	:Incorporating search functionality enables users to locate specific information within the application by entering keywords or applying filters. 
	:These inputs are then processed on the backend to retrieve pertinent data from the database. Introducing a new field to the database schema 
	 requires adjustments to the structure, such as adding a new column or attribute, to accommodate the expanded data storage. Corresponding updates
	 to the application's codebase are essential to manage the new field effectively, ensuring smooth integration and functionality.
.
.
.
.
2024-02-21
2105
Review : Add validation and Examine Details and Delete

Model: 

:-> Adding validation: 
	:Adding validation ensures that the data entered by users meets specific criteria or constraints before it is stored in the database. 
	:This process includes various checks such as verifying mandatory fields, validating input formats like email addresses or phone numbers, ensuring
	 data falls within defined ranges such as dates or numerical values, and safeguarding against malicious input like SQL injection. By implementing
	 these checks, validation plays a vital role in preserving data integrity and reducing the risk of storing incorrect or inappropriate data in the 
	 database.

:-> Examine Details and Delete: 
	:The Examine Details and Delete functionality allows users to access detailed information about a particular record or entity within the 
	 application, typically through a dedicated "details" page. 
	:This page presents all relevant details about the record and may offer additional actions or choices related to that specific record. 
	:Users also have the option to delete records if necessary, usually by selecting a "delete" button or link. However, it's essential to incorporate
	 confirmation dialogs or other protective measures to prevent accidental deletion, as deleting a record permanently removes it from the database.
	:These safeguards help users make informed decisions and prevent unintended data loss.



Outputs:


			Elite Flowers
Add Flower

FlowerType	Size	 Color	  Price	  Quantity	
Rose		Mediam	 Red	  20.00	  3.00	   Edit | Details | Delete
Sun Flower	Large	 Yellow	  20.00	  2.00	   Edit | Details | Delete
Tulip		Small	 Purple	  10.00	  5.00	   Edit | Details | Delete
Orchid		Medium	 White	  30.00	  1.00	   Edit | Details | Delete
Marigold	Large	 Yellow	  5.00	  2.00	   Edit | Details | Delete


Observation:
:-> Validation ensures that user input meets certain criteria to maintain data integrity. 
   The examine details feature enables users to access detailed information about individual records, while deletion functionality includes 
   safeguards to prevent accidental removal. These improvements empower users to manage data efficiently, enhancing the overall user experience.
:-> the significance of two key features: validation and the examine details functionality, along with deletion safeguards. Validation ensures that user
    input aligns with specific criteria, thereby preserving data integrity. Meanwhile, the examine details feature grants users access to comprehensive 
    information about individual records, enhancing their ability to manage data effectively. Additionally, the deletion functionality includes safeguards 
    against accidental removal, further contributing to efficient data management. 
:-> These enhancements empower users with streamlined data management capabilities, leading to a more user-centric experience.





Distribution :


Smit:

Introduction: Decided on project topics like FlowerType, Size, Color, Price, and Quantity.
Model: Models manage data in Elite Flower apps; discussed attributes like DataType for data types.
Database: Covered working with databases and seeding for initial data population.
Controllers and Views: Defined controller actions and views' roles in rendering interfaces.

Kejan:

Database: Emphasized the importance of working with databases and DBMS.
Search and Field Addition: Discussed integrating search functionality and adding new fields to the schema.
Validation and Details: Highlighted the significance of validation in data integrity and features like examining details.

Amandeep:

Introduction: Introduced Elite Flower architecture and project topics.
Model and Views: Explained the roles of models, views, and controllers.
Database and Deletion: Covered database management and features like deletion with safeguards.
