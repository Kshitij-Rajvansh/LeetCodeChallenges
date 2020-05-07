using System;

namespace May
{
    public class Problem_7
    {
        /*

        */

        // Solution starts
        public bool IsCousins(TreeNode root, int x, int y) {
        if(root == null)
        {
            return false;
        }
        
        getDepthAndParent(root, x, y, 0, null);
        
        return depthX == depthY && parentX != parentY ? true : false;
    }
    
    // calculate depth and keep track of parent
    public void getDepthAndParent(TreeNode root, int x, int y, int depth, TreeNode parent){
        if(root == null){
            return;
        }
        if(root.val == x){
            parentX = parent;
            depthX = depth;
        }else if(root.val == y){
            parentY = parent;
            depthY = depth;
        }       
        getDepthAndParent(root.left, x, y, depth + 1, root);
        getDepthAndParent(root.right, x, y, depth + 1, root);
    }
        // Solution ends
    }
}