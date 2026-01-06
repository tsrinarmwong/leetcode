# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        res = []

        if not root: #if tree is empty, skip
            return res

        q = collections.deque() #an empty queue
        q.append(root) #Hmmm what does this do?

        while q: #What is this again?
            same_level = [] #list for level-by-level

            for _ in range(len(q)): #???
                node = q.popleft() #take the left most item to var node
                same_level.append(node.val) #add the val from node to same_level

                # why this? Is this for like adding the child to it?
                if node.left: 
                    q.append(node.left)
                if node.right:
                    q.append(node.right)
            
            # once the same level has been iterated, add to list.
            res.append(same_level)

        return res
