using UnityEngine;

[CreateAssetMenu(fileName = "ModelFactory", menuName = "Factories/ModelFactory", order = 1)]
public class ModelFactory:ScriptableObject
{
    [SerializeField] private Model modelPrefab;
    public Model CreateModel(ModelConfig modelConfig, Transform parentTransform, ModelSides modelSide, int intersectionDistance)
    {
        Model model = Instantiate(modelPrefab, parentTransform);
        model.Initialize(modelConfig, modelSide, intersectionDistance);
        return model;
    }
}
