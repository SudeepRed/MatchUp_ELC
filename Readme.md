# Match Up

## Problem Statement:
People have different body shapes and the online stores rarely address this since the models generally wearing the clothes have perfect figure.

It is difficult to buy apparel online as you haven't tried it yet as you would do so in physical stores. People have different body shapes and the online stores do not address this since the models generally wearing the clothes have perfect figure. Sometimes one company’s sizing chart differs from another and this becomes a hassle while shopping online.
## Solution:
A way to visualize how the clothes would look like on the user's specific body type.
## Solution Architecture
<img src="https://github.com/SudeepRed/MatchUp_V2/blob/main/Images/Architecture.svg">

## Survey
We conducted a preliminary survey to get valuable insights into people who shop online and develop a broad understanding of our problem area. There were a total of 100 participants in the survey.

Our questions revolved around the experience of online shopping.
[Link](https://docs.google.com/forms/d/12WyTBNDkLx_l6Ltsf7nzvqyBInZtQHw4eLOcp1K0tYI/edit)
### Key insigths from our survey:
1. The participants were from 15-40 years of age, the majority belonged to 18-25.
2. Almost 45% of people have never used online bought clothes/accessories. 
3. The majority of the people agreed that trying and returning items is inconvenient(47.4%).
4. People prefer in-store shopping and also felt the need to make online shopping more comfortable and realistic.
5. The size and look of the clothes/accessories remain the most commonly faced challenges. 
<img src="https://github.com/SudeepRed/MatchUp_V2/blob/main/Images/GFrom_summary.svg">

## Companies/Apps giving customers Try-n-Buy experience
1. Wanna Kicks
2. Crocs LiteRide AR
3. Gap – Gap Dressing Room AR App by Avametric
4. Nike SNKRS
5. RIXO London
6. Lacoste
7. Converse – The Converse Sampler App
8. Moosejaw
9. Airwalk – Invisible Pop Up Store by GoldRun

## Competetive Analysis
<img src="https://github.com/SudeepRed/MatchUp_V2/blob/main/Images/Table.svg">

## Architecture of the solution

### Used [Skinned Multi-Person Linear Model (SMPL)](https://smpl.is.tue.mpg.de/) body model:
- SMPL is a realistic 3D model of the human body that is based on skinning, blend shapes and is learned from thousands of 3D body scans.
- The SMPL model contains 200+ BlendShapes (also known as ShapeKeys in blender) which can fine tune the basic mesh into any body type.

**We narrowed down the blendshapes from 200+ to mere 10 to account for the APK size and performance.** 

The blendshapes focus on various measurements of the human body like height, weight, waist, bust, hips, inseam and shoulder length.
We use these blendshapes to reshape the 3D mesh to the desired human body model.
<img src="https://github.com/SudeepRed/MatchUp_V2/blob/main/Images/Ex.svg">
### Used Blender3D:
- To make python scripts to transfer ShapeKeys from SMPL model to clothing assets perfectly.
- To transfer weights from SMPL model to clothing assets.
- To generate accurate skin textures so that lighting and shadows need not be recalculated when the app is run.
### Unity3D:
- Used Unity3D’s “SkinnedMeshRenderer” to morph the SMPL model into different body shapes.
- The animations were made such that they can blend with the morph targets to make reliable and consistent body shapes.

## Previous Versions
1. [Version 1](https://github.com/SudeepRed/MatchUp) 
    - [V1 Demo](https://www.youtube.com/watch?v=ss9RnIUmpm0)











