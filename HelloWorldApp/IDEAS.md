# Games
**Weeding Game** - A game for removing weeds experimenting with different strategies.

**SolarPunk Stardew** - A stardew valley clone with more paths than farming where players can specialize or branch-out on different jobs
- Researcher
- Artist
- Baker
- Farmer
- Tree Reclamation
- Builder

**Sustainable Incremental** - Incremental games exist to watch the number go up. What if the goal was instead to find a sustainable solution. What if number go up is the wrong optimization?
- Start with coal which produces energy when burned - that's our "clicker". Each time energy is captured, we watch number go up.
- Coal is finite, so number stops going up and the player gets a "game over" with the time survived.
- They can get really good at clicking, but that actually means they survive less time.
- They can unlock other energy sources, ability to capture energy so it can be clicked on before "floating off the screen", more clickers to use the enrgy, etc.
- Perhaps a loop is optimized so much that fision becomes possible and they unlock the achievement "infinite energy". (for now an acceptable "game over")
	- Then the starter screen has a new option to "start with infinite energy"
	- This game mode optimizes for yet another variable

**Game Scraps** - These are ideas that can be compiled to make an actual tangible idea
- A "citybuilder" where teh player can jump into the lives of different roles: planner (default), researcher (for those menus), miner (where they would literally go dig fior coal)
	- Perhaps the more a player interacts with a particular role, the more efficient that role becomes; but it should be super boring so the player is incentivized as the "planner" to make that role's life better.
	- Each role would be a different mini-game
- City builder with square meeples in black & white art style; they could get little hats like Kirby when they specialize

# Work
**Dependency Task Estimator** - A utilitiy that estimates the time and resources required to fulfill several dependencies that roll up to the overall task.
- Provides stacked bar chart to show where much of the time is spent.

# Agriculture
**Farm Layers** - A utilitiy to view the data at each section of a plot of land.
- Provides a map of the plot using a grid/matrix with several different measurements: 
	- Soil type
	- Moisture content
	- Crop yield
	- Herbicide, pesticide, or fungicide presence
	- Elevation
	- Shade

**Garden Planner** - Focusing on Spacing and simple colors - expand the plants by season for intercropping and continuous harvest. It should model the size and shade cast by plants at various stages.

# Solarpunk and Eco-Friendly
**Library of Things** - Library extensions for tools, equipment, perishables and other items with additional fields for instructions, size, story, etc.

**Communal Extension** 
- An editor of the Library (or other applications) that enables development version control tools that allows users to interface with a service or game to provide research for extensions.
- Version Control, PR, Blockchain? for contributions
Examples:
- An interface with a garden game to add new plants based on research (provided as references) to be reviewed by others and approved. - Would likely need moderators to ensure we don't end up with silly things added.
	- This may start with research and then move to a phase for art or mechanics
	- Perhaps there is a form with variables required and references to those variables?
	- It could allow a user to modify an existing element or add a brand new one.
- An interface with the Library of Things where a person can add a new Item or even Item type to be reviewed by others and approved.
- Extensions to the Solarpunk world (game or imagination) based on research or ideas | collaborative world-building

**Energy Calculator**
- Where can we turn down the lights, return to analog, or stake some energy vampires? Where does it make sense to do so without squashing the value added by energy? Where can we use the law of diminishing returns to our advantage to make large cuts in energy for minimal cuts in experience?

**Carbon Calculator**
- Calculate the carbon (or methane, etc.) used by specific meals, activities, travel, etc. using an external library (API) of data

# Research
## AI
**Minimum Prompt** - Validate that having fewer prompts is actually fewer resources, then learn how to reduce prompts to still get accurate results.

**AI Heuristic** - Based on different factors (quality, energy usage, benefit, ethics), is __this use-case__ a good time to use AI?

## Benchmarks
Leveraging BenchmarkDotNet, create a bunch of benchmarks for different use-cases: copying files, managing latency, etc.


# Fun
**Sleeper** - Rank fantasy football teams using the Sleeper API and optimize for silly variables.
- Give me the best team for Best-Ball where all the player's names start with "C"

**Trade-Calculator** - Given a current state and desired future state, provide a flow diagram of "fair" trades to move through the states.
- Ideally we can provide the model with feedback to develop a "personality" for each member that the trades are conducted with to improve the models accuracy.