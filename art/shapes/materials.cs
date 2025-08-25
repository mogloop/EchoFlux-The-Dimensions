
singleton Material(monolith_Material)
{
   mapTo = "unmapped_mat";
   translucentBlendOp = "None";
};

singleton Material(Grid512_ForestGreenLines_Mat)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "core/art/grids/512_forestgreen_lines";
   materialTag0 = "TestMaterial";
};

singleton Material(Grid512_Grey_Mat)
{
   mapTo = "Material";
   diffuseMap[0] = "core/art/grids/512_grey";
   materialTag0 = "TestMaterial";
   diffuseColor[0] = "0.992157 0.996078 0.835294 1";
   accuScale[0] = "0.03125";
   accuDirection[0] = "-1";
};



singleton Material(Grid512_GreyBase_Mat)
{
   mapTo = "Material";
   diffuseMap[0] = "core/art/grids/512_grey_base";
   materialTag0 = "TestMaterial";
};
