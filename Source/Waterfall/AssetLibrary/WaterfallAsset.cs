﻿namespace Waterfall
{
  public enum AssetWorkflow
  {
    Dynamic,
    Deforming,
    Billboards,
    Light,
    Volumetric,
    Other
  }

  public class WaterfallAsset
  {
    public string        Name        = "default";
    public string        Description = "default description";
    public AssetWorkflow Workflow;
    public string        Path;

    public WaterfallAsset() { }

    public WaterfallAsset(ConfigNode node)
    {
      Load(node);
    }

    public virtual void Load(ConfigNode node)
    {
      node.TryGetEnum("workflow", ref Workflow, AssetWorkflow.Other);
      node.TryGetValue("description", ref Description);
      node.TryGetValue("name",        ref Name);
      node.TryGetValue("path",        ref Path);
    }
  }
}